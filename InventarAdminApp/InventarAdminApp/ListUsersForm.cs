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
        private API api;

        public ListUsersForm(API _api)
        {
            api = _api;
            InitializeComponent();
            FillTable(api.ListUsers());
        }

        private void FillTable(List<UserData> _userdata)
        {
            userdataTable.Rows.Clear();
            foreach (UserData ud in _userdata)
            {
                string[] userdata = ud.ToStrings();
                userdataTable.Rows.Add(userdata);
            }
        }

        private void addPermissionButton_Click(object sender, EventArgs e)
        {
            var cells = userdataTable.SelectedCells;
            string username = (string) cells[0].Value;
            Console.WriteLine(api.AddPermission(username, permissionInput.Text));
            FillTable(api.ListUsers());
        }
    }
}
