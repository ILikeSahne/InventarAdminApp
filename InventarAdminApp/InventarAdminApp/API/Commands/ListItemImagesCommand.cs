using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventarAPI
{
    class ListItemImagesCommand : Command
    {
        private Item i;

        public ListItemImagesCommand(Item _i) : base("ListItemImages")
        {
            i = _i;
        }

        public override object Execute(User _u, StreamHelper _helper)
        {
            _helper.SendString(i.ItemCollectionName);
            _helper.SendString(i.ID);

            string response = _helper.ReadString();
            if (response != okResponse)
                return response;

            int amount = _helper.ReadInt();
            List<byte[]> images = new List<byte[]>();
            for(int i = 0; i < amount; i++)
            {
                images.Add(_helper.ReadByteArray());
            }
            i.Bilder = images;
            return i;
        }

    }
}
