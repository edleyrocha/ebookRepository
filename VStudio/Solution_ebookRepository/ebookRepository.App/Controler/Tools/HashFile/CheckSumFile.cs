#region ---> [USING]

using System;
using System.IO;
using System.Security.Cryptography;

#endregion

#region ---> [NAMESPACE]

namespace HashFile
{

    #region ---> [CLASS]

    class CheckSumFile : IDisposable
    {

        #region ---> [FILDS]

        public readonly HashAlgorithm MD5;
        public readonly HashAlgorithm SHA1;
        public readonly HashAlgorithm SHA256;
        public readonly HashAlgorithm SHA384;
        public readonly HashAlgorithm SHA512;
        public readonly HashAlgorithm RIPEMD160;

        #endregion

        #region ---> [CONSTRUTORS]

        public CheckSumFile()
        {
            MD5 = new MD5CryptoServiceProvider();
            SHA1 = new SHA1Managed();
            SHA256 = new SHA256Managed();
            SHA384 = new SHA384Managed();
            SHA512 = new SHA512Managed();
            RIPEMD160 = new RIPEMD160Managed();
        }
        public void Dispose()
        {
            GC.Collect();
        }
        ~CheckSumFile()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        public string GetHashFromFile(string File_Full_Patch, HashAlgorithm Hash_Algorithm)
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

        #endregion

        #region ---> [COMENTS]

        /*
         * 
         * http://azuliadesigns.com/calculate-md5-checksum-file/
         * 
         */

        #endregion

    }

    #endregion

}

#endregion