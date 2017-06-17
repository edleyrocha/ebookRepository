#region ---> [USING]

using System;
using System.IO;
using ebookRepository.App.Controler.Tools.DebugApp;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Tools.Files
{

    #region ---> [CLASS]

    class Check_FileName
    {

        #region ---> [METHODS]

        public static string GET_FileNameWithoutExtension(string File_Full_Patch)
        {
            LogAppMode.PrintTheLog();
            LogAppMode.PrintTheLog("GET_FileNameWithoutExtension() [INICIO]");
            if (File.Exists(File_Full_Patch))
            {
                File_Full_Patch = (Path.GetFileNameWithoutExtension(File_Full_Patch));
                LogAppMode.PrintTheLog("GET_FileNameWithoutExtension() ---> [" + File_Full_Patch +"]");
            }
            else
            {
                File_Full_Patch = String.Empty;
                LogAppMode.PrintTheLog("GET_FileNameWithoutExtension() ---> [NAO EXISTE]");
            }
            LogAppMode.PrintTheLog("GET_FileNameWithoutExtension() [FIM]");
            return (File_Full_Patch);
        }

        public static string GET_FileNameExtensions(string File_Full_Patch)
        {
            LogAppMode.PrintTheLog();
            LogAppMode.PrintTheLog("GET_FileNameExtensions() [INICIO]");
            if (File.Exists(File_Full_Patch))
            {
                File_Full_Patch = (Path.GetExtension(File_Full_Patch));
                LogAppMode.PrintTheLog("GET_FileNameExtensions() ---> [" + File_Full_Patch + "]");
            }
            else
            {
                File_Full_Patch = String.Empty;
                LogAppMode.PrintTheLog("GET_FileNameExtensions() ---> [NAO EXISTE]");
            }
            LogAppMode.PrintTheLog("GET_FileNameExtensions() [FIM]");
            return (File_Full_Patch);
        }

        #endregion

    }

    #endregion

}

#endregion
