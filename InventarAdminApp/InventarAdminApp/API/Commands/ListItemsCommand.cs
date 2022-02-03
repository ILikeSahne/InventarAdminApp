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
                throw new Exception(response);

            int amount = _helper.ReadInt();
            List<Item> items = new List<Item>();
            DateTime now = DateTime.Now;
            _helper.SendInt(items.Count);
            for (int i = 0; i < amount; i++)
            {
                Item item = JsonSerializer.Deserialize<Item>(_helper.ReadString());
                item.ItemCollectionName = name;
                items.Add(item);
            }
            Console.WriteLine(DateTime.Now - now);
            return items;
        }

    }
}
