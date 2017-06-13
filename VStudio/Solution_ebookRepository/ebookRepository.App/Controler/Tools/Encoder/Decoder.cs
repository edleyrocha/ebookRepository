#region ---> [USING]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

#endregion
namespace ebookRepository.App.Controler.Tools.Encoder
{
    class Decoder
    {

        public static string DecodeToString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
        public static byte[] DecodeToBytes(string str)
        {
            bool even = str[0] == '0';
            byte[] bytes = new byte[(str.Length - 1) * sizeof(char) + (even ? 0 : -1)];
            char[] chars = str.ToCharArray();
            System.Buffer.BlockCopy(chars, 2, bytes, 0, bytes.Length);
            return bytes;
        }
    }
}
