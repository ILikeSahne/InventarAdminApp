using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    class AddNewUserCommand : Command
    {
        private string email, username, password;

        public AddNewUserCommand(string _email, string _username, string _password) : base("AddNewUser")
        {
            email = _email;
            username = _username;
            password = _password;
        }

        public override object Execute(User _u, StreamHelper _helper)
        {
            string response = _helper.ReadString();
            if (response != okResponse)
                return response;

            _helper.SendString(email);
            _helper.SendString(username);
            _helper.SendString(password);

            response = _helper.ReadString();
            return response;
        }
    }
}
