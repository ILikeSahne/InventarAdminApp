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
    public partial class ListUsersForm : Form
    {
        public ListUsersForm(List<UserData> _userdata)
        {
            InitializeComponent();
            FillTable(_userdata);
        }

        private void FillTable(List<UserData> _userdata)
        {
            foreach (UserData ud in _userdata)
            {
                string[] userdata = ud.ToStrings();
                userdataTable.Rows.Add(userdata);
            }
        }
    }
}
