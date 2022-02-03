using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    class AddExcelItemsCommand : Command
    {
        private string name, filename;

        public AddExcelItemsCommand(string _name, string _filename) : base("AddExcelItems")
        {
            name = _name;
            filename = _filename;
        }

        public override object Execute(User _u, StreamHelper _helper)
        {
            if (!File.Exists(filename))
                throw new FileNotFoundException();

            string response = _helper.ReadString();
            if (response != okResponse)
                throw new Exception(response);

            _helper.SendString(name);

            response = _helper.ReadString();
            if (response != okResponse)
                throw new Exception(response);

            byte[] bytes = File.ReadAllBytes(filename);
            _helper.SendByteArray(bytes);

            return _helper.ReadInt();
        }
    }
}
