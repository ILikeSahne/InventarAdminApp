using InventarAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarAdminApp
{
    public partial class Form1 : Form
    {
        private API api;

        private List<Item> items;

        public Form1()
        {
            InitializeComponent();
            api = new API(10000);
            //Console.WriteLine(api.Login("bulme", "ilikesahne@gmx.at", "Pw123XYZ12").ToString());
            LoadServers();
        }

        private void LoadServers()
        {
            serverDropDown.Items.Clear();
            List<string> databases = api.GetDabases();
            if(databases == null)
            {
                Error("Server is offline!");
                return;
            }
            foreach(string name in databases)
            {
                serverDropDown.Items.Add(name);
            }
        }

        private void addNewDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!api.LoggedIn())
                Login();
            CreateNewDatabaseForm newDb = new CreateNewDatabaseForm(CreateNewDatabase);
            newDb.Show();
        }

        private bool CreateNewDatabase(CreateNewDatabaseForm form)
        {
            if (!api.LoggedIn())
                Login();
            string response = api.CreateNewDatabase(nameInput.Text, passwordInput.Text, form.DatabaseName, form.AdminEmail, form.AdminUsername, form.AdminPassword);
            if (response == "OK") {
                Success("Database " + form.DatabaseName + " created!");
                return true;
            } else
                Error(response);
            return false;
        }

        private void Error(string _error)
        {
            errorLabel.ForeColor = Color.Red;
            errorLabel.Text = _error;
        }

        private void Success(string _success)
        {
            errorLabel.ForeColor = Color.Green;
            errorLabel.Text = _success;
        }

        private LoginError Login()
        {
            return api.Login(serverDropDown.Text, nameInput.Text, passwordInput.Text);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginError error = Login();
            if (error == LoginError.NONE)
            {
                Success("Login successfull!");
                ShowItems();
            }
            else
            {
                Error(error.ToString());
            }
        }

        private void ShowItems()
        {
            if (!api.LoggedIn())
                Login();
            itemTable.Rows.Clear();
            items = api.ListItems();
            foreach(Item i in items) {
                itemTable.Rows.Add(i.ToStrings());
                Console.WriteLine(i.ID);
            }
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!api.LoggedIn())
                Login();
            AddNewItemForm newItem = new AddNewItemForm(AddNewItem);
            newItem.Show();
        }

        private bool AddNewItem(AddNewItemForm form)
        {
            if (!api.LoggedIn())
                Login();
            string response = api.AddItem(form.Item);
            if (response == "OK")
            {
                Success("Item added!");
                return true;
            }
            else
                Error(response);
            return false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (items == null)
            {
                Error("No Items!");
                return;
            }
            var rows = itemTable.SelectedRows;
            List<Item> removes = new List<Item>();
            foreach(DataGridViewRow row in rows)
            {
                Item i = items[row.Index];
                string response = api.DeleteItem(i);
                if (response == "OK")
                {
                    Success("Item(s) deleted!");
                    removes.Add(i);
                }
            }
            items = items.Except(removes).ToList();
            ShowItems();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!api.LoggedIn())
                Login();
            AddNewUserForm newUser = new AddNewUserForm(AddNewUser);
            newUser.Show();
        }

        private bool AddNewUser(AddNewUserForm form)
        {
            if (!api.LoggedIn())
                Login();
            string response = api.AddUser(form.Username, form.Email, form.Password);
            if (response == "OK")
            {
                Success("User added!");
                return true;
            }
            else
                Error(response);
            return false;
        }
    }
}
