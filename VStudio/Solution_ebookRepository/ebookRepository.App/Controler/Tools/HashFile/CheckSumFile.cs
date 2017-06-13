#region ---> [USING]

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.IO;
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

        #region ---> [CONSTRUCTOR]

        public CheckSumFile()
        {

        }

        #endregion

        #region ---> [METHODS]

        public static string GetHashFromFile(String File_Full_Patch, HashAlgorithm Hash_Algorithm)
        {
            using (var stream = new BufferedStream(File.OpenRead(File_Full_Patch), 100000))
            {
                return BitConverter.ToString(Hash_Algorithm.ComputeHash(stream)).Replace("-", string.Empty);
            }
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
