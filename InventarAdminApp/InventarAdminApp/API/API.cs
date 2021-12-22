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

        private string db, name, pw;

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

        public bool LoggedIn()
        {
            return db != null;
        }

        public void CloseConnection()
        {
            helper.SendString("Close");
            if (client != null)
            {
                client.Close();
                client = null;
            }
        }

        public List<string> GetDabases()
        {
            try
            {
                OpenConnection();
                helper.SendString("ListDatabases");
                List<string> databases = new List<string>();
                int len = helper.ReadInt();
                for (int i = 0; i < len; i++)
                {
                    databases.Add(helper.ReadString());
                }
                CloseConnection();
                return databases;
            } catch(Exception e)
            {
                return null;
            }
        }

        public LoginError Login(string _db, string _name, string _pw)
        {
            db = _db;
            name = _name;
            pw = _pw;
            try
            {
                OpenConnection();
                helper.SendString("Login");
                helper.SendString(db);
                helper.SendString(name);
                helper.SendString(pw);
                string response = helper.ReadString();
                API.WriteLine("Response: {0}", response);
                CloseConnection();
                return GetErrorFromString(response);
            }
            catch (Exception e)
            {
                return LoginError.SERVER_NOT_RESPONDING;
            }
        }

        private LoginError GetErrorFromString(string _error)
        {
            foreach (LoginError e in Enum.GetValues(typeof(LoginError)))
            {
                if (e.ToString().Equals(_error))
                    return e;
            }
            return LoginError.UNKNOWN;
        }

        public string CreateNewDatabase(string _adminUsername, string _adminPassword, string _dbName, string _dbAdminEmail, string _dbAdminUsername, string _dbAdminPassword)
        {
            OpenConnection();
            helper.SendString("CreateNewDatabase");
            helper.SendString(_adminUsername);
            helper.SendString(_adminPassword);

            string response = helper.ReadString();
            if(response != okResponse)
                return "Error: " + response;

            helper.SendString(_dbName);
            helper.SendString(_dbAdminEmail);
            helper.SendString(_dbAdminUsername);
            helper.SendString(_dbAdminPassword);

           response = helper.ReadString();
            if (response != okResponse)
                return "Error: " + response;

            CloseConnection();

            return "OK";
        }

        public string AddUser(string username, string email, string password)
        {
            OpenConnection();

            helper.SendString("AddNewUser");
            helper.SendString(db);
            helper.SendString(name);
            helper.SendString(pw);

            string response = helper.ReadString();
            if (response != okResponse)
                return "Error: " + response;

            helper.SendString(username);
            helper.SendString(email);
            helper.SendString(password);

            response = helper.ReadString();
            if (response != okResponse)
                return "Error: " + response;

            return "OK";
        }

        public string AddItemCollection(string _itemCollection)
        {
            OpenConnection();

            helper.SendString("AddNewItemCollection");
            helper.SendString(db);
            helper.SendString(name);
            helper.SendString(pw);

            helper.SendString(_itemCollection);

            string response = helper.ReadString();
            if (response != okResponse)
                return "Error: " + response;

            return "OK";
        }

        public string AddItem(Item _i, string _itemCollection)
        {
            OpenConnection();

            helper.SendString("AddNewItem");
            helper.SendString(db);
            helper.SendString(name);
            helper.SendString(pw);

            string response = helper.ReadString();
            if (response != okResponse)
                return "Error: " + response;

            helper.SendString(_itemCollection);
            string json = JsonSerializer.Serialize(_i);
            helper.SendString(json);

            response = helper.ReadString();
            if (response != okResponse)
                return "Error: " + response;

            return "OK";
        }

        public string DeleteItem(Item _i, string _itemCollection)
        {
            OpenConnection();

            helper.SendString("DeleteItem");
            helper.SendString(db);
            helper.SendString(name);
            helper.SendString(pw);

            string response = helper.ReadString();
            if (response != okResponse)
                return "Error: " + response;

            helper.SendString(_itemCollection);
            helper.SendString(_i.ID);

            return "OK";
        }

        public List<Item> ListItems(string _itemCollection)
        {
            OpenConnection();
            helper.SendString("ListItems");
            helper.SendString(db);
            helper.SendString(name);
            helper.SendString(pw);

            string response = helper.ReadString();
            if (response != okResponse)
                return null;

            helper.SendString(_itemCollection);
            int amountOfItems = helper.ReadInt();
            List<Item> items = new List<Item>();
            for(int i = 0; i < amountOfItems; i++)
            {
                string json = helper.ReadString();
                Item item = JsonSerializer.Deserialize<Item>(json);
                items.Add(item);
            }

            return items;
        }

        public List<string> ListItemCollections()
        {
            OpenConnection();

            helper.SendString("ListItemCollectionNames");
            helper.SendString(db);
            helper.SendString(name);
            helper.SendString(pw);

            string response = helper.ReadString();
            if (response != okResponse)
                return null;

            int amountOfItemCollection = helper.ReadInt();
            List<string> itemCollections = new List<string>();
            for (int i = 0; i < amountOfItemCollection; i++)
            {
                string itemCollectionName = helper.ReadString();
                itemCollections.Add(itemCollectionName);
            }
            return itemCollections;
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
        NONE, SERVER_NOT_RESPONDING, WRONG_DATABASE, WRONG_USERNAME, WRONG_PASSWORD, UNKNOWN
    }
}
