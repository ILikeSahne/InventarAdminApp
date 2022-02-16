using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    public class GeneratePDFCommand : Command
    {
        private DocumentType dt;

        public GeneratePDFCommand(DocumentType _dt) : base("GeneratePDF")
        {
            dt = _dt;
        }

        public override object Execute(User _u, StreamHelper _helper)
        {
            string response = _helper.ReadString();
            if (response != okResponse)
                throw new Exception(response);

            _helper.SendString(dt.ToString());

            response = _helper.ReadString();
            if (response != okResponse)
                throw new Exception(response);

            byte[] pdf = _helper.ReadByteArray();
            return pdf;
        }
    }

    public enum DocumentType
    {
        ABSCHREIBUNG
    }
}
