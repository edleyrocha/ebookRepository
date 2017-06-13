#region ---> [USING]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

#endregion
namespace ebookRepository.App.Controler.Tools
{
    #region ---> [Class]
    class HexPassword
    {
        #region ---> [Construtor]
        public SQLite_HexPassword()
        {

        }
        #endregion

        #region ---> [Methods]
        public static byte[] Get_Bytes_from_String(string strings)
        {
            byte[] bytes = new byte[strings.Length * sizeof(char)];
            System.Buffer.BlockCopy(strings.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        public static string Get_String_from_Bytes(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
        public static string GetHex_to_Bytes(byte[] bytes)
        {
            return (BitConverter.ToString(bytes));
        }
        #endregion
    }
    #endregion
}
