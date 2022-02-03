using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    class ListUserCommand : Command
    {
        public ListUserCommand() : base("ListUser")
        { }

        public override object Execute(User _u, StreamHelper _helper)
        {
            string response = _helper.ReadString();
            if (response != okResponse)
                throw new Exception(response);

            List<UserData> users = new List<UserData>();
            int amount = _helper.ReadInt();
            for(int i = 0; i < amount; i++)
            {
                users.Add(UserData.FromJson(_helper.ReadString()));
            }

            return users;
        }
    }
}
