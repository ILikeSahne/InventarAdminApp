using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventarAPI
{
    public class User
    {
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string _db, string _username, string _password)
        {
            Database = _db;
            Username = _username;
            Password = _password;
        }

        public LoginError Login(StreamHelper _helper)
        {
            _helper.SendString(Database);
            _helper.SendString(Username);
            _helper.SendString(Password);

            string response = _helper.ReadString();
            return API.LoginErrorFromString(response);
        }
    }

    class UserData
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public List<string> Permissions { get; set; }

        public UserData()
        { }

        public UserData(string _email, string _username, List<string> _permissions)
        {
            Email = _email;
            Username = _username;
            Permissions = _permissions;
        }

        public static UserData FromJson(string _json)
        {
            return JsonSerializer.Deserialize<UserData>(_json);
        }
    }
}
