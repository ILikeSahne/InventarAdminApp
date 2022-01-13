using InventarAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarAdminApp
{
    public partial class AddNewItemForm : Form
    {
        public Item Item { get; set; } 

        private Func<AddNewItemForm, bool> onDataSendClick;

        public AddNewItemForm(Func<AddNewItemForm, bool> _onDataSendClick, string _itemCollection)
        {
            InitializeComponent();
            onDataSendClick = _onDataSendClick;
            Item = new Item();
            Item.ItemCollectionName = _itemCollection;
        }

        private void _sendDataButton_Click(object sender, EventArgs e)
        {
            Item.ID = "";
            Item.Anlage = anlageInput.Text;
            Item.Unternummer = unternummerInput.Text;
            Item.AktuelleInventarNummer = aktuelleNummerInput.Text;
            Item.AktivierungAm = aktivirungAmInput.Value;
            Item.Anlagenbezeichnung = anlagenBezeichnungInput.Text;
            Item.Serialnummer = serialNummerInput.Text;
            Item.AnschaffungsWert = Decimal.ToDouble(anschaffWertInput.Value);
            Item.BuchWert = Decimal.ToDouble(buchWertInput.Value);
            Item.Waehrung = waehrungInput.Text;
            Item.KfzKennzeichen = kfzKennzeichenInput.Text;
            Item.Raum = raumInput.Text;
            Item.RaumBezeichnung = raumBezeichungInput.Text;
            Item.Status = statusInput.Text;
            Item.Notiz = notizInput.Text;
            Item.Bilder = new List<byte[]>();
            Item.Verlauf = new List<string>();
            Item.Permission = permissionInput.Text;
            if (onDataSendClick(this))
                Close();
        }
    }
}
