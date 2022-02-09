using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    class CopyItemCollectionCommand : Command
    {
        private string nameToCopy, newName, permission;

        public CopyItemCollectionCommand(string _nameToCopy, string _newName, string _permission) : base("CopyItemCollection")
        {
            nameToCopy = _nameToCopy;
            newName = _newName;
            permission = _permission;
        }

        public override object Execute(User _u, StreamHelper _helper)
        {
            string response = _helper.ReadString();
            if (response != okResponse)
                throw new Exception(response);

            _helper.SendString(nameToCopy);
            _helper.SendString(newName);
            _helper.SendString(permission);

            response = _helper.ReadString();
            if(response != okResponse)
                throw new Exception(response);
            return response;
        }
    }
}
