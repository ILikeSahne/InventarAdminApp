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
    public partial class CreateNewDatabaseForm : Form
    {
        public string DatabaseName { get; set; }
        public string AdminEmail { get; set; }
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }

        private Func<CreateNewDatabaseForm, bool> onDataSendClick;

        public CreateNewDatabaseForm(Func<CreateNewDatabaseForm, bool> _onDataSendClick)
        {
            InitializeComponent();
            onDataSendClick = _onDataSendClick;
        }

        private void _sendDataButton_Click(object sender, EventArgs e)
        {
            DatabaseName = databaseNameInput.Text;
            AdminEmail = adminEmailInput.Text;
            AdminUsername = adminUsernameInput.Text;
            AdminPassword = adminPasswordInput.Text;
            if (onDataSendClick(this))
                Close();
        }
    }
}
