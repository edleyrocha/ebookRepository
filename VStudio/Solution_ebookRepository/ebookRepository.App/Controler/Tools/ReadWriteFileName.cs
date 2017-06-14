using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebookRepository.App.Controler.Tools
{
    class ReadWriteFileName
    {

        public static byte[] File_ReadAllBytes(String File_Full_Patch)
        {
            var bytes = File.ReadAllBytes(File_Full_Patch);
            return (bytes);
        }

        public static bool File_WriteAllBytes(String File_Full_Patc, byte[] bytesArray)
        {
            var myReturn_bool = (false);
            File.WriteAllBytes(File_Full_Patc, bytesArray);
            if (File.Exists(File_Full_Patc))
            {
                myReturn_bool = (true);
            }
            return (myReturn_bool);
        }

    }
}
