using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    public class Command
    {
        public const string okResponse = "OK";

        public string Name { get; set; }

        public Command(string _name)
        {
            Name = _name;
        }

        public object Call(User _u, StreamHelper _helper)
        {
            _helper.SendString(Name);
            return Execute(_u, _helper);
        }

        public virtual object Execute(User _u, StreamHelper _helper)
        {
            return "";
        }
    }
}
