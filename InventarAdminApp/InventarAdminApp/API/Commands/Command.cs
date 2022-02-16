using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
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

        public static byte[] Zip(string uncompressed)
        {
            byte[] ret;
            using (var outputMemory = new MemoryStream())
            {
                using (var gz = new GZipStream(outputMemory, CompressionLevel.Optimal))
                {
                    using (var sw = new StreamWriter(gz, Encoding.UTF8))
                    {
                        sw.Write(uncompressed);
                    }
                }
                ret = outputMemory.ToArray();
            }
            return ret;
        }

        public static string Unzip(byte[] compressed)
        {
            string ret = null;
            using (var inputMemory = new MemoryStream(compressed))
            {
                using (var gz = new GZipStream(inputMemory, CompressionMode.Decompress))
                {
                    using (var sr = new StreamReader(gz, Encoding.UTF8))
                    {
                        ret = sr.ReadToEnd();
                    }
                }
            }
            return ret;
        }
    }
}
