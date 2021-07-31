using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace InventarAdminApp
{
    class API
    {
        private string domain;
        private int port;

        private TcpClient client;
        private NetworkStream stream;

        private RSAHelper rsaHelper;
        private StreamHelper helper;

        private string db, email, pw;

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

        private LoginError OpenConnection()
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
            helper.SendString(db);
            helper.SendString(email);
            helper.SendString(pw);
            return LoginError.NO_ERROR;
        }

        public void CloseConnection()
        {
            if (client != null)
            {
                client.Close();
                client = null;
            }
        }

        public LoginError Login(string _db, string _email, string _pw)
        {
            db = _db;
            email = _email;
            pw = _pw;
            try
            {
                LoginError e = OpenConnection();
                CloseConnection();
                return e;
            } catch (Exception e)
            {
                return LoginError.SERVER_NOT_RESPONDING;
            }
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
