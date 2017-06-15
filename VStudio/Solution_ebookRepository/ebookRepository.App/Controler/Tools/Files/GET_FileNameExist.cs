#region ---> [USING]

using System;
using System.IO;

#endregion

namespace ebookRepository.App.Controler.Tools.Files
{

    #region ---> [CLASS]

    class GET_FileNameExist
    {

        #region ---> [METHODS]

        public static bool GET_FileNameExist_From_PatchFile(string File_Full_Patch)
        {
            var existFile = (false);
            if (File.Exists(File_Full_Patch))
            {
                existFile = (true);
            }
            return (existFile);
        }

        #endregion

    }

    #endregion

}
