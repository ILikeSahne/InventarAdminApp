using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InventarAPI;

namespace InventarAdminApp
{
    public partial class LoginForm : Form
    {
        public API Instance { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Instance = new API(textBoxURL.Text.Trim(), (int)numericPort.Value);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
