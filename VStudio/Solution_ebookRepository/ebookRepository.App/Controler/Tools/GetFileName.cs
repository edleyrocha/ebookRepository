#region ---> [USING]

using System;
using System.IO;

#endregion

namespace ebookRepository.App.Controler.Tools
{

    #region ---> [CLASS]

    class GetFileName
    {

        #region ---> [METHODS]

        public static string GetFileName_From_PatchFile(String File_Full_Patch)
        {
            File_Full_Patch = (Path.GetFileName(File_Full_Patch));
            return (File_Full_Patch);
        }

        #endregion

    }

    #endregion

}
