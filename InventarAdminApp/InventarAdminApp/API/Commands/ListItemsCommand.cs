using System;
using System.Collections.Generic;
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
                return response;

            int amount = _helper.ReadInt();
            List<Item> items = new List<Item>();
            for(int i = 0; i < amount; i++)
            {
                Item item = JsonSerializer.Deserialize<Item>(_helper.ReadString());
                items.Add(item);
            }
            return items;
        }

    }
}
