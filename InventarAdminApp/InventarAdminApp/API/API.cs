﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    class API
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
            OpenConnection();
            helper.SendString("ListDatabases");
            List<string> databases = new List<string>();
            int len = helper.ReadInt();
            for(int i = 0; i < len; i++)
            {
                databases.Add(helper.ReadString());
            }
            CloseConnection();
            return databases;
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
                return LoginError.NO_ERROR;
            } catch (Exception e)
            {
                return LoginError.SERVER_NOT_RESPONDING;
            }
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

        public static void WriteLine(string _s, params object[] _args)
        {
#if DEBUG
            Console.WriteLine(_s, _args);
#endif
        }
    }

    public enum LoginError
    {
        NO_ERROR, SERVER_NOT_RESPONDING, WRONG_DATABASE, WRONG_USERNAME, WRONG_PASSWORD
    }
}
