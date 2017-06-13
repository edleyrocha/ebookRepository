using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashFile;

namespace ebookRepository.App.Controler.Tools.HashFile
{
    public class GetHashCheckSum
    {
        public static string ReturnMD5(string File_Full_Patch)
        {
      
            var myReturn_String = (CheckSumFile.GetHashFromFile(@File_Full_Patch: File_Full_Patch, Hash_Algorithm: CheckSumFile.MD5));
            return (myReturn_String);
        }
        public static string ReturnSHA1(string File_Full_Patch)
        {

            var myReturn_String = (CheckSumFile.GetHashFromFile(@File_Full_Patch: File_Full_Patch, Hash_Algorithm: CheckSumFile.SHA1));
            return (myReturn_String);
        }

        public static string ReturnSHA256(string File_Full_Patch)
        {

            var myReturn_String = (CheckSumFile.GetHashFromFile(@File_Full_Patch: File_Full_Patch, Hash_Algorithm: CheckSumFile.SHA256));
            return (myReturn_String);
        }
        public static string ReturnSHA384(string File_Full_Patch)
        {

            var myReturn_String = (CheckSumFile.GetHashFromFile(@File_Full_Patch: File_Full_Patch, Hash_Algorithm: CheckSumFile.SHA384));
            return (myReturn_String);
        }
        public static string ReturnSHA512(string File_Full_Patch)
        {

            var myReturn_String = (CheckSumFile.GetHashFromFile(@File_Full_Patch: File_Full_Patch, Hash_Algorithm: CheckSumFile.SHA512));
            return (myReturn_String);
        }

    }
}
