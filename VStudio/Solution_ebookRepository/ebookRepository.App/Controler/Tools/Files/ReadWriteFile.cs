#region ---> [USING]

using System;
using System.IO;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Tools.Files
{

    #region ---> [CLASS]
    class ReadWriteFile
    {

        #region ---> [METHODS]

        public byte[] File_ReadAllBytes(string File_Full_Patch)
        {
            byte[] bytes = (null);
            if (File.Exists(File_Full_Patch))
            {
                bytes = (File.ReadAllBytes(File_Full_Patch));
            }
            return (bytes);
        }

        public bool File_WriteAllBytes(string File_Full_Patch, byte[] bytesArray)
        {
            bool myReturn_bool = (false);
            if (!(string.IsNullOrEmpty(File_Full_Patch)))
            {
                try
                {
                    File.WriteAllBytes(File_Full_Patch, bytesArray);
                    myReturn_bool = (true);
                }
                catch (Exception ex)
                {
                    ebookRepository.App.Controler.Tools.DebugApp.LogAppMode.PrintTheLog("File_WriteAllBytes() ---> " + "[" + myReturn_bool + "] [ERRO]", 1);
                    ebookRepository.App.Controler.Tools.DebugApp.LogAppMode.PrintTheLog(ex.Message, 2);
                    myReturn_bool = (false);
                }
            }
            return (myReturn_bool);
        }

        #endregion

    }

    #endregion

}

#endregion