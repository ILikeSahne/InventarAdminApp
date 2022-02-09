using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventarAPI
{
    class ChangeItemImagesCommand : Command
    {
        private Item i;

        public ChangeItemImagesCommand(Item _i) : base("ChangeItemImages")
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

            _helper.SendInt(i.Bilder.Count);
            foreach(byte[] img in i.Bilder)
            {
                _helper.SendByteArray(img);
            }
            return okResponse;
        }

    }
}
