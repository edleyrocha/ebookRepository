#region ---> [USING]

using System;
using HashFile;

#endregion

namespace ebookRepository.App.Controler.Tools.HashFile
{

    #region ---> [CLASS]

    public class GetHashCheckSum
    {

        #region ---> [METHODS]
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

        #endregion

    }

    #endregion

}
