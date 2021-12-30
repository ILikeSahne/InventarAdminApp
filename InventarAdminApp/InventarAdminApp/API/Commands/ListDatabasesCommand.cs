using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    public class ListDatabasesCommand : Command
    {
        public ListDatabasesCommand() : base("ListDatabases")
        { }

        public override object Execute(User _u, StreamHelper _helper)
        {
            List<string> databases = new List<string>();
            int amount = _helper.ReadInt();
            for(int i = 0; i < amount; i++)
                databases.Add(_helper.ReadString());
            return databases;
        }
    }
}
