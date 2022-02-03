using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventarAPI
{
    class ListItemsCommand : Command
    {
        private string name;

        public ListItemsCommand(string _name) : base("ListItems")
        {
            name = _name;
        }

        public override object Execute(User _u, StreamHelper _helper)
        {
            _helper.SendString(name);

            string response = _helper.ReadString();
            if (response != okResponse)
                throw new Exception(response);

            DateTime now = DateTime.Now;
            string json = Unzip(_helper.ReadByteArray());
            List<Item> items = JsonSerializer.Deserialize<List<Item>>(json);
            Console.WriteLine(DateTime.Now - now);
            return items;
        }

        public static string Unzip(byte[] compressed)
        {
            string ret = null;
            using (var inputMemory = new MemoryStream(compressed))
            {
                using (var gz = new GZipStream(inputMemory, CompressionMode.Decompress))
                {
                    using (var sr = new StreamReader(gz, Encoding.UTF8))
                    {
                        ret = sr.ReadToEnd();
                    }
                }
            }
            return ret;
        }

    }
}
