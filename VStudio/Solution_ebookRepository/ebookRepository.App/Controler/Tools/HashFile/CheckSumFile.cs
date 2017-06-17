#region ---> [USING]

using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

#endregion
namespace HashFile
{

    #region ---> [CLASS]

    public class CheckSumFile
    {

        #region ---> [FILDS]

        public static readonly HashAlgorithm MD5 = new MD5CryptoServiceProvider();
        public static readonly HashAlgorithm SHA1 = new SHA1Managed();
        public static readonly HashAlgorithm SHA256 = new SHA256Managed();
        public static readonly HashAlgorithm SHA384 = new SHA384Managed();
        public static readonly HashAlgorithm SHA512 = new SHA512Managed();
        public static readonly HashAlgorithm RIPEMD160 = new RIPEMD160Managed();

        #endregion

        #region ---> [METHODS]

        public static string GetHashFromFile(string File_Full_Patch, HashAlgorithm Hash_Algorithm)
        {
            if (File.Exists(File_Full_Patch))
            {
                using (var stream = new BufferedStream(File.OpenRead(File_Full_Patch), 100000))
                {
                    return BitConverter.ToString(Hash_Algorithm.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
            else
            {
                return (string.Empty);
            }
        }

        public static string GetHashFromFile2(string File_Full_Patch, HashAlgorithm Hash_Algorithm, ref ProgressBar ProgressBar)
        {
            if (File.Exists(File_Full_Patch))
            {

            }
            else
            {
               
            }
            return (string.Empty);
        }
        #endregion

        /*
         * 
         * http://azuliadesigns.com/calculate-md5-checksum-file/
         * 
         */
    }

    #endregion

}
