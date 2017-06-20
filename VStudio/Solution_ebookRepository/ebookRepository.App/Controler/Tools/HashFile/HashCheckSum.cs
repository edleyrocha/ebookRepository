#region ---> [USING]

using System;
using HashFile;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Tools.HashFile
{

    #region ---> [CLASS]

    public class HashCheckSum : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~HashCheckSum()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        public string ReturnMD5(string File_Full_Patch)
        {
            using (var _CheckSumFile = (new CheckSumFile()))
            {
                return (_CheckSumFile.GetHashFromFile(File_Full_Patch, _CheckSumFile.MD5));
            };
        }

        public string ReturnSHA1(string File_Full_Patch)
        {
            using (var _CheckSumFile = (new CheckSumFile()))
            {
                return (_CheckSumFile.GetHashFromFile(File_Full_Patch, _CheckSumFile.SHA1));
            };
        }

        public string ReturnSHA256(string File_Full_Patch)
        {
            using (var _CheckSumFile = (new CheckSumFile()))
            {
                return (_CheckSumFile.GetHashFromFile(File_Full_Patch, _CheckSumFile.SHA256));
            };
        }

        public string ReturnSHA384(string File_Full_Patch)
        {
            using (var _CheckSumFile = (new CheckSumFile()))
            {
                return (_CheckSumFile.GetHashFromFile(File_Full_Patch, _CheckSumFile.SHA384));
            };
        }
        public string ReturnSHA512(string File_Full_Patch)
        {
            using (var _CheckSumFile = (new CheckSumFile()))
            {
                return (_CheckSumFile.GetHashFromFile(File_Full_Patch, _CheckSumFile.SHA512));
            };
        }

        #endregion

    }

    #endregion

}

#endregion