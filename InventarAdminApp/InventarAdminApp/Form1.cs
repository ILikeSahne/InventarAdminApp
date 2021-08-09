using InventarAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarAdminApp
{
    public partial class Form1 : Form
    {
        private API api;

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
            foreach(string name in databases)
            {
                serverDropDown.Items.Add(name);
            }
        }

        private void addNewDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            api.CreateNewDatabase(nameInput.Text, passwordInput.Text);
        }
    }
}
