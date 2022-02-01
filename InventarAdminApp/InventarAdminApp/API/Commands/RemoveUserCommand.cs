using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    class RemoveUserCommand : Command
    {
        private string username;

        public RemoveUserCommand(string _username) : base("RemoveUser")
        {
            username = _username;
        }

        public override object Execute(User _u, StreamHelper _helper)
        {
            string response = _helper.ReadString();
            if (response != okResponse)
                return response;

            _helper.SendString(username);

            response = _helper.ReadString();
            return response;
        }
    }
}
