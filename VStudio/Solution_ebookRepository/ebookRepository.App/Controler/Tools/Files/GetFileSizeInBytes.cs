#region ---> [USING]

using System;
using System.IO;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Tools.Files
{

    #region ---> [CLASS]

    class GetFileSizeInBytes : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~GetFileSizeInBytes()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        public string GetSizeFile(string File_Full_Patch)
        {
            long myReturn_Long = (-1);

            if (File.Exists(File_Full_Patch))
            {
                myReturn_Long = new FileInfo(File_Full_Patch).Length;
            }
            return (Convert.ToString(myReturn_Long));
        }

        #endregion

    }

    #endregion

}

#endregion