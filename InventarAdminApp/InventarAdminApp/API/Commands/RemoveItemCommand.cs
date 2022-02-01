using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    public class RemoveItemCommand : Command
    {
        private Item item;

        public RemoveItemCommand(Item _i) : base("RemoveItem")
        {
            item = _i;
        }

        public override object Execute(User _u, StreamHelper _helper)
        {
            _helper.SendString(item.ItemCollectionName);
            _helper.SendString(item.ID);

            string response = _helper.ReadString();
            return response;
        }
    }
}
