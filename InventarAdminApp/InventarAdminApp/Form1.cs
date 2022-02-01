using InventarAPI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            // Console.WriteLine(api.Login("bulme", "ilikesahne@gmx.at", "Pw123XYZ12").ToString());
            LoadServers();
        }

        private void LoadServers()
        {
            serverDropDown.Items.Clear();
            List<string> databases = api.SendListDatabasesCommand();
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
            string response = api.CreateNewDatabase(form.DatabaseName, form.AdminEmail, form.AdminUsername, form.AdminPassword);
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
            api.Login(serverDropDown.Text, nameInput.Text, passwordInput.Text);
            LoginError e = api.SendLoginCommand();
            return e;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginError error = Login();
            if (error == LoginError.NONE)
            {
                Success("Login successfull!");
                ListItemCollections();
            }
            else
            {
                Error(error.ToString());
            }
        }

        private void ListItemCollections()
        {
            List<string> itemCollections = api.ListItemCollections();
            itemCollectionDropDown.Items.Clear();
            foreach (string s in itemCollections)
            {
                itemCollectionDropDown.Items.Add(s);
            }
        }

        private void ShowItems()
        {
            if (!api.LoggedIn())
                Login();
            itemTable.Rows.Clear();
            items = api.ListItems(itemCollectionDropDown.Text);
            foreach(Item i in items) {
                string[] data = i.ToStrings();
                string[] dataWithoutID = new string[data.Length - 1];
                for(int j = 1; j < data.Length; j++)
                {
                    dataWithoutID[j - 1] = data[j];
                }
                itemTable.Rows.Add(dataWithoutID);
            }
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!api.LoggedIn())
                Login();
            AddNewItemForm newItem = new AddNewItemForm(AddNewItem, itemCollectionDropDown.Text);
            newItem.Show();
        }

        private bool AddNewItem(AddNewItemForm form)
        {
            if (!api.LoggedIn())
                Login();
            Item response = api.AddItem(form.Item);
            if (response != null)
            {
                Success("Item added!");
                MessageBox.Show(response.ToString());
                return true;
            }
            else
                Error("Item adding failed!");
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
                
                string response = api.RemoveItem(i);
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
            string response = api.AddUser(form.Email, form.Username, form.Password);
            if (response == "OK")
            {
                Success("User added!");
                return true;
            }
            else
                Error(response);
            return false;
        }

        private void showItemsButton_Click(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void addItemCollectionButton_Click(object sender, EventArgs e)
        {
            string response = api.AddItemCollection(itemCollectionNameInput.Text, itemCollectionPermissionInput.Text);
            if (response == "OK")
                Success("Item Collection added!");
            else
                Error(response);
            ListItemCollections();
        }

        private void showUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListUsersForm listUsers = new ListUsersForm(api);
            listUsers.Show();
        }
    }
}
