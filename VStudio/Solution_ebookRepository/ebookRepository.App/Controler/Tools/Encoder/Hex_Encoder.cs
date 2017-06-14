using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebookRepository.App.Controler.Tools.Encoder
{
    class Hex_Encoder
    {
        public static string ByteArray_to_HexArray(byte[] bytes)
        {
            return (BitConverter.ToString(bytes));
        }
        public static byte[] HexArry_to_ByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
    }
}
