using System;
using System.Collections.Generic;

namespace InventarAPI
{
    class ListItemCollectionsCommand : Command
    {
        public ListItemCollectionsCommand() : base("ListItemCollections")
        { }

        public override object Execute(User _u, StreamHelper _helper)
        {
            List<string> itemCollections = new List<string>();
            int amount = _helper.ReadInt();
            for (int i = 0; i < amount; i++)
            {
                itemCollections.Add(_helper.ReadString());
            }

            return itemCollections;
        }
    }
}
