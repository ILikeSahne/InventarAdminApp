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
        private string itemCollection;
        private List<string> ids;
        private string additionalInfo;

        public GeneratePDFCommand(DocumentType _dt, string _itemCollection, List<string> _ids, string _additionalInfo) : base("GeneratePDF")
        {
            dt = _dt;
            itemCollection = _itemCollection;
            ids = _ids;
            additionalInfo = _additionalInfo;
        }

        public GeneratePDFCommand(DocumentType _dt, string _itemCollection, List<string> _ids) : this(_dt, _itemCollection, _ids, "")
        { }

        public override object Execute(User _u, StreamHelper _helper)
        {
            string response = _helper.ReadString();
            if (response != okResponse)
                throw new Exception(response);

            _helper.SendString(dt.ToString());
            _helper.SendString(itemCollection);

            response = _helper.ReadString();
            if (response != okResponse)
                throw new Exception(response);

            _helper.SendInt(ids.Count);
            foreach(string id in ids)
                _helper.SendString(id);

            response = _helper.ReadString();
            if (response != okResponse)
                throw new Exception(response);

            _helper.SendString(additionalInfo);

            byte[] pdf = _helper.ReadByteArray();
            return pdf;
        }
    }

    public enum DocumentType
    {
        ABSCHREIBUNG
    }
}
