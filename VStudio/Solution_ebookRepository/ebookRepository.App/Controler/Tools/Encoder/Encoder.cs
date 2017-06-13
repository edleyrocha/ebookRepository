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
    class Encoder
    {
        public static string EncodeToString(byte[] bytes)
        {
            bool even = (bytes.Length % 2 == 0);
            char[] chars = new char[1 + bytes.Length / sizeof(char) + (even ? 0 : 1)];
            chars[0] = (even ? '0' : '1');
            System.Buffer.BlockCopy(bytes, 0, chars, 2, bytes.Length);
            return new string(chars);
        }

        public static byte[] EncodeToBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

    }
}
