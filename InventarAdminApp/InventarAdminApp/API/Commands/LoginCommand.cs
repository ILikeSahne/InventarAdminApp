using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    public class LoginCommand : Command
    {
        public LoginCommand() : base("Login")
        { }

        public override object Execute(User _u, StreamHelper _helper)
        {
            return okResponse;
        }
    }
}
