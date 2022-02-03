using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventarAPI
{
    public class API
    {
        private const string okResponse = "OK";

        private string domain;
        private int port;

        private TcpClient client;
        private NetworkStream stream;

        private RSAHelper rsaHelper;
        private StreamHelper helper;

        private User user;

        public API(string _domain, int _port)
        {
            domain = _domain;
            port = _port;
        }

        public API(int _port)
        {
            domain = "127.0.0.1";
            port = _port;
        }

        private void OpenConnection()
        {
            client = new TcpClient();
            IAsyncResult result = client.BeginConnect(Dns.GetHostAddresses(domain)[0], port, null, null);

            bool success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));
            client.EndConnect(result);
            if (!success)
                throw new Error("Couldn't connect to Server!");

            stream = client.GetStream();
            rsaHelper = new RSAHelper(stream);
            try
            {
                rsaHelper.SetupClient();
            }
            catch (Exception e)
            {
                WriteLine("Error: {0}", e.ToString());
            }
            helper = new StreamHelper(rsaHelper);
        }

        public void Login(string _db, string _username, string _password)
        {
            user = new User(_db, _username, _password);
        }

        public bool LoggedIn()
        {
            return user != null;
        }

        public object SendCommand(Command _c, out LoginError _error)
        {
            _error = LoginError.NONE;
            if (!LoggedIn())
            {
                _error = LoginError.NOT_LOGGED_IN;
                return "Login first";
            }

            OpenConnection();
            LoginError e = user.Login(helper);
            if (e != LoginError.NONE)
            {
                CloseConnection();
                _error = e;
                return e.ToString();
            }

            object response = _c.Call(user, helper);

            CloseConnection();

            return response;
        }

        public List<object> SendCommands(List<Command> _commands, out LoginError _error)
        {
            _error = LoginError.NONE;
            List<object> errors = new List<object>();
            if (!LoggedIn())
            {
                errors.Add("Login first");
                return errors;
            }

            OpenConnection();
            LoginError e = user.Login(helper);
            if (e != LoginError.NONE)
            {
                CloseConnection();
                _error = e;
                errors.Add(e);
                return errors;
            }

            foreach (Command c in _commands)
            {
                string response = (string) c.Call(user, helper);
                errors.Add(response);
            }

            CloseConnection();

            return errors;
        }

        public void CloseConnection()
        {
            if (client != null)
            {
                client.Close();
                client = null;
            }
        }

        public LoginError SendLoginCommand()
        {
            LoginError error;
            SendCommand(new LoginCommand(), out error);

            return error;
        }

        public List<string> SendListDatabasesCommand()
        {
            if(user == null)
                user = new User("", "", "");

            LoginError error;
            object response = SendCommand(new ListDatabasesCommand(), out error);
            if (user.Username == "")
                user = null;
            
            if (error != LoginError.NONE)
                return new List<string>();
            return (List<string>) response;
        }

        public string CreateNewDatabase(string _dbName, string _dbAdminEmail, string _dbAdminUsername, string _dbAdminPassword)
        {
            LoginError error;
            object response = SendCommand(new CreateNewDatabaseCommand(_dbName, _dbAdminEmail, _dbAdminUsername, _dbAdminPassword), out error);

            if (error != LoginError.NONE)
                return error.ToString();
            return response.ToString();
        }

        public string AddUser(string _email, string _username, string _password)
        {
            LoginError error;
            object response = SendCommand(new AddUserCommand(_email, _username, _password), out error);

            if (error != LoginError.NONE)
                return error.ToString();
            return response.ToString();
        }

        public List<UserData> ListUsers()
        {
            LoginError error;
            object response = SendCommand(new ListUserCommand(), out error);

            if (error != LoginError.NONE)
                return null;
            return (List<UserData>) response;
        }

        public string AddPermission(string _username, string _permission)
        {
            LoginError error;
            object response = SendCommand(new AddPermissionCommand(_username, _permission), out error);

            if (error != LoginError.NONE)
                return null;
            return response.ToString();
        }

        public string RemovePermission(string _username, string _permission)
        {
            LoginError error;
            object response = SendCommand(new RemovePermissionCommand(_username, _permission), out error);

            if (error != LoginError.NONE)
                return null;
            return response.ToString();
        }

        public string AddItemCollection(string _name, string _permission)
        {
            LoginError error;
            object response = SendCommand(new AddItemCollectionCommand(_name, _permission), out error);

            if (error != LoginError.NONE)
                return error.ToString();
            return response.ToString();
        }

        public string RemoveItemCollection(string _name)
        {
            LoginError error;
            object response = SendCommand(new RemoveItemCollectionCommand(_name), out error);

            if (error != LoginError.NONE)
                return error.ToString();
            return response.ToString();
        }

        public Item AddItem(Item _i)
        {
            LoginError error;
            object response = SendCommand(new AddItemCommand(_i), out error);

            if (error != LoginError.NONE)
                return null;
            return (Item) response;
        }

        public string RemoveItem(Item _i)
        {
            LoginError error;
            object response = SendCommand(new RemoveItemCommand(_i), out error);

            if (error != LoginError.NONE)
                return null;
            return response.ToString();
        }

        public List<Item> ListItems(string _itemCollection)
        {
            LoginError error;
            object response = SendCommand(new ListItemsCommand(_itemCollection), out error);

            if (error != LoginError.NONE)
                return null;
            return (List<Item>)response;
        }

        public Item LoadItemImages(Item _i)
        {
            LoginError error;
            object response = SendCommand(new ListItemImagesCommand(_i), out error);

            if (error != LoginError.NONE)
                return null;
            return (Item) response;
        }

        public List<string> ListItemCollections()
        {
            LoginError error;
            object response = SendCommand(new ListItemCollectionsCommand(), out error);

            if (error != LoginError.NONE)
                return null;
            return (List<string>)response;
        }

        public static LoginError LoginErrorFromString(string _e)
        {
            foreach (LoginError e in Enum.GetValues(typeof(LoginError)))
            {
                if (e.ToString().Equals(_e))
                    return e;
            }
            return LoginError.UNKNOWN;
        } 

        public static void WriteLine(string _s, params object[] _args)
        {
#if DEBUG
            Console.WriteLine(_s, _args);
#endif
        }
    }

    public enum LoginError
    {
        NONE, SERVER_NOT_RESPONDING, WRONG_DATABASE, WRONG_USERNAME, WRONG_PASSWORD, NOT_LOGGED_IN, UNKNOWN
    }
}
