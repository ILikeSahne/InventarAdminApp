using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    class CreateNewDatabaseCommand : Command
    {
        private string database, email, username, password;

        public CreateNewDatabaseCommand(string _database, string _email, string _username, string _password) : base("CreateNewDatabase")
        {
            database = _database;
            email = _email;
            username = _username;
            password = _password;
        }

        public override object Execute(User _u, StreamHelper _helper)
        {
            string response = _helper.ReadString();
            if (response != okResponse)
                return response;

            _helper.SendString(database);
            _helper.SendString(email);
            _helper.SendString(username);
            _helper.SendString(password);

            response = _helper.ReadString();
            return response;
        }
    }
}
