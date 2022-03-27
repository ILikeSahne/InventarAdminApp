using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarAPI
{
    public class StreamHelper
    {
        public RSAHelper Helper { get; }
        private ASCIIEncoding ascii;

        public StreamHelper(RSAHelper _helper)
        {
            Helper = _helper;
            ascii = new ASCIIEncoding();
        }

        public void SendByteArray(byte[] _bytes)
        {
            Helper.WriteByteArray(_bytes);
        }

        public byte[] ReadByteArray()
        {
            return Helper.ReadByteArray();
        }

        public void SendString(string _s)
        {
            SendByteArray(ascii.GetBytes(_s));
        }

        public string ReadString()
        {
            return ascii.GetString(ReadByteArray());
        }

        public void SendInt(int _x)
        {
            SendByteArray(BitConverter.GetBytes(_x));
        }

        public int ReadInt()
        {
            byte[] array = ReadByteArray();
            return BitConverter.ToInt32(array, 0);
        }
    }
}
