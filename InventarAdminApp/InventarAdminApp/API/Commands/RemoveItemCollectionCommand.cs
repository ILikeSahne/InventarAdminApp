using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    public class RemoveItemCollectionCommand : Command
    {
        private string collectionName;

        public RemoveItemCollectionCommand(string _collectionName) : base("RemoveItemCollection")
        {
            collectionName = _collectionName;
        }

        public override object Execute(User _u, StreamHelper _helper)
        {
            _helper.SendString(collectionName);

            string response = _helper.ReadString();
            if(response != okResponse)
                throw new Exception(response);
            return response;
        }
    }
}
