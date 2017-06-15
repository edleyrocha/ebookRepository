#region ---> [USING]

using System;
using System.IO;

#endregion

namespace ebookRepository.App.Controler.Tools.Files
{

    #region ---> [CLASS]
    class ReadWriteFile
    {

        #region ---> [METHODS]

        public static byte[] File_ReadAllBytes(String File_Full_Patch)
        {
            byte[] bytes = (null);
            if (File.Exists(File_Full_Patch))
            {
                bytes = (File.ReadAllBytes(File_Full_Patch));
            }
            return (bytes);
        }

        public static bool File_WriteAllBytes(String File_Full_Patch, byte[] bytesArray)
        {
            bool myReturn_bool = (false);

            if (!(string.IsNullOrEmpty(File_Full_Patch)))
            {
                try
                {
                    File.WriteAllBytes(File_Full_Patch, bytesArray);
                    myReturn_bool = (true);
                }
                catch // (Exception ex)
                {
                    //   ex = null;
                    myReturn_bool = (false);
                }
            }

            return (myReturn_bool);
        }

        #endregion

    }

    #endregion

}
