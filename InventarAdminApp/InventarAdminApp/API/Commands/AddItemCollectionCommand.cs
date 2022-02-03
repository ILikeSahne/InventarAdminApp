using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    class AddItemCollectionCommand : Command
    {
        private string name, permission;

        public AddItemCollectionCommand(string _name, string _permission) : base("AddItemCollection")
        {
            name = _name;
            permission = _permission;
        }

        public override object Execute(User _u, StreamHelper _helper)
        {
            string response = _helper.ReadString();
            if (response != okResponse)
                throw new Exception(response);

            _helper.SendString(name);
            _helper.SendString(permission);

            response = _helper.ReadString();
            if(response != okResponse)
                throw new Exception(response);
            return response;
        }
    }
}
