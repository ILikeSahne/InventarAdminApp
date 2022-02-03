using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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

        public static Item GetItemEntry(string _collectionName, string _id)
        {
            Item i = new Item();
            i.ID = _id;
            i.ItemCollectionName = _collectionName;
            return i;
        }

        public static Item FromByteArray(byte[] data)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(data))
            {
                //ItemStorage i = (ItemStorage) bf.Deserialize(ms);
                Item i = new Item();

                i.ItemCollectionName = (string) bf.Deserialize(ms);
                i.ID = (string) bf.Deserialize(ms);

                i.Anlage = (string) bf.Deserialize(ms);
                i.Unternummer = (string) bf.Deserialize(ms);
                i.AktuelleInventarNummer = (string) bf.Deserialize(ms);
                i.AktivierungAm = (DateTime) bf.Deserialize(ms);
                i.Anlagenbezeichnung = (string) bf.Deserialize(ms);
                i.Serialnummer = (string) bf.Deserialize(ms);
                i.AnschaffungsWert = (double) bf.Deserialize(ms);
                i.BuchWert = (double) bf.Deserialize(ms);
                i.Waehrung = (string) bf.Deserialize(ms);
                i.KfzKennzeichen = (string) bf.Deserialize(ms);
                i.Raum = (string) bf.Deserialize(ms);
                i.RaumBezeichnung = (string) bf.Deserialize(ms);

                i.Status = (string) bf.Deserialize(ms);
                i.Notiz = (string) bf.Deserialize(ms);
                i.BarcodeLabelOk = (bool) bf.Deserialize(ms);
                i.Bilder = (List<byte[]>) bf.Deserialize(ms);
                i.Verlauf = (List<string>) bf.Deserialize(ms);
                i.Permission = (string) bf.Deserialize(ms);

                return i;
            }
        }
    }
}
