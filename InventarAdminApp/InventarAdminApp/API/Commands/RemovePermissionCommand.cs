using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    class RemovePermissionCommand : Command
    {
        private string username, permission;

        public RemovePermissionCommand(string _username, string _permission) : base("RemovePermission")
        {
            username = _username;
            permission = _permission;
        }

        public override object Execute(User _u, StreamHelper _helper)
        {
            string response = _helper.ReadString();
            if (response != okResponse)
                return response;

            _helper.SendString(username);
            _helper.SendString(permission);
            return okResponse;
        }
    }
}
