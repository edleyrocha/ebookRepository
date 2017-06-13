using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebookRepository.App.Controler.Tools.Encoder
{
    class Hex_Encoder
    {
        public static string GetHex_to_Bytes(byte[] bytes)
        {
            return (BitConverter.ToString(bytes));
        }
    }
}
