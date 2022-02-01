using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace InventarAPI
{
    public class Item
    {
        public string ItemCollectionName { get; set; }
        public string ID { get; set; }
        public string Anlage { get; set; }
        public string Unternummer { get; set; }
        public string AktuelleInventarNummer { get; set; }
        public DateTime AktivierungAm { get; set; }
        public string Anlagenbezeichnung { get; set; }
        public string Serialnummer { get; set; }
        public double AnschaffungsWert { get; set; }
        public double BuchWert { get; set; }
        public string Waehrung { get; set; }
        public string KfzKennzeichen { get; set; }
        public string Raum { get; set; }
        public string RaumBezeichnung { get; set; }
        public string Status { get; set; }
        public string Notiz { get; set; }
        public bool BarcodeLabelOk { get; set; }
        public List<byte[]> Bilder { get; set; }
        public List<string> Verlauf { get; set; }
        public string Permission { get; set; }

        public Item()
        {
            ID = "";
        }

        public string[] ToStrings()
        {
            return new string[]
            {
                ID,
                Anlage,
                Unternummer,
                AktuelleInventarNummer,
                AktivierungAm.ToString(),
                Anlagenbezeichnung,
                Serialnummer,
                AnschaffungsWert.ToString(),
                BuchWert.ToString(),
                Waehrung,
                KfzKennzeichen,
                Raum,
                RaumBezeichnung,
                Status,
                Notiz,
                BarcodeLabelOk.ToString(),
                Permission
            };
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string s in ToStrings())
            {
                builder.AppendLine(s);
            }
            return builder.ToString();
        }
    }
}
