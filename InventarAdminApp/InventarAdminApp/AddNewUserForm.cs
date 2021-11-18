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
    public partial class AddNewUserForm : Form
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private Func<AddNewUserForm, bool> onDataSendClick;

        public AddNewUserForm(Func<AddNewUserForm, bool> _onDataSendClick)
        {
            InitializeComponent();
            onDataSendClick = _onDataSendClick;
        }

        private void _sendDataButton_Click(object sender, EventArgs e)
        {
            Username = usernameInput.Text;
            Email = emailInput.Text;
            Password = passwordInput.Text;

            if (onDataSendClick(this))
                Close();
        }
    }
}
