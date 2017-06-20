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

        public string GET_FileNameWithoutExtension(string File_Full_Patch)
        {

            if (File.Exists(File_Full_Patch))
            {
                File_Full_Patch = (Path.GetFileNameWithoutExtension(File_Full_Patch));
            }
            else
            {
                File_Full_Patch = String.Empty;
            }
            return (File_Full_Patch);
        }

        public string GET_FileNameExtensions(string File_Full_Patch)
        {
            if (File.Exists(File_Full_Patch))
            {
                File_Full_Patch = (Path.GetExtension(File_Full_Patch));
            }
            else
            {
                File_Full_Patch = String.Empty;
            }
            return (File_Full_Patch);
        }

        #endregion

    }

    #endregion

}

#endregion
