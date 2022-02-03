using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    class AddPermissionCommand : Command
    {
        private string username, permission;

        public AddPermissionCommand(string _username, string _permission) : base("AddPermission")
        {
            username = _username;
            permission = _permission;
        }

        public override object Execute(User _u, StreamHelper _helper)
        {
            string response = _helper.ReadString();
            if (response != okResponse)
                throw new Exception(response);

            _helper.SendString(username);
            _helper.SendString(permission);
            return okResponse;
        }
    }
}
