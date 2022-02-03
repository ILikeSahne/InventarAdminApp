using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventarAPI
{
    class AddItemCommand : Command
    {
        private Item item;

        public AddItemCommand(Item _i) : base("AddItem")
        {
            item = _i;
        }

        public override object Execute(User _u, StreamHelper _helper)
        {
            string response = _helper.ReadString();
            if (response != okResponse)
                throw new Exception(response);

            string json = JsonSerializer.Serialize(item);
            _helper.SendString(json);
            Item i = JsonSerializer.Deserialize<Item>(_helper.ReadString());
            return i;
        }
    }
}
