#region ---> [USING]

using System;
using System.IO;

#endregion

namespace ebookRepository.App.Controler.Tools.Files
{

    #region ---> [CLASS]

    class GET_FileName
    {

        #region ---> [METHODS]

        public static string GET_FileName_From_PatchFile(string File_Full_Patch)
        {
            if (File.Exists(File_Full_Patch))
            {
                File_Full_Patch = (Path.GetFileName(File_Full_Patch));
            }
            else if (!File.Exists(File_Full_Patch))
            {
                File_Full_Patch = String.Empty;
            }
                return (File_Full_Patch);
        }

        #endregion

    }

    #endregion

}
