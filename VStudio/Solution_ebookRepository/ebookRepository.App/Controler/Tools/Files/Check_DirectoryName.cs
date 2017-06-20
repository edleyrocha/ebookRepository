#region ---> [USING]

using System;
using System.IO;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Tools.Files
{

    #region ---> [CLASS]

    class Check_DirectoryName
    {

        #region ---> [METHODS]

        public void GetDirFile()
        {
            System.Collections.Generic.List<object> ListObjectsDiretorios = new System.Collections.Generic.List<object>();
            ListObjectsDiretorios.Add(System.AppDomain.CurrentDomain.BaseDirectory);
            ListObjectsDiretorios.Add(System.IO.Directory.GetCurrentDirectory());
            ListObjectsDiretorios.Add(System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath));
            ListObjectsDiretorios.Add(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
            ListObjectsDiretorios.Add(System.Environment.CurrentDirectory);
            ListObjectsDiretorios.Add(System.Threading.Thread.GetDomain().BaseDirectory);

            string ListDiretorios = "";
            for (int i = 0; i < ListObjectsDiretorios.Count; i++)
            {
                ListDiretorios += String.Format("{0}\n \n", (string)ListObjectsDiretorios[i]);
            }
            System.Windows.Forms.MessageBox.Show(ListDiretorios, "Diretorio");

            System.Collections.Generic.List<object> ListObjectsFile = new System.Collections.Generic.List<object>();
            ListObjectsFile.Add(System.AppDomain.CurrentDomain.FriendlyName);
            ListObjectsFile.Add(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            ListObjectsFile.Add(System.IO.Path.GetFileNameWithoutExtension((string)(ListObjectsFile[1])));
            ListObjectsFile.Add(System.IO.Path.GetFileName((string)(ListObjectsFile[1])));
            ListObjectsFile.Add(System.IO.Path.GetExtension((string)(ListObjectsFile[1])));
            ListObjectsFile.Add(System.IO.Path.GetFullPath((string)(ListObjectsFile[1])));
            ListObjectsFile.Add(System.IO.Path.GetRandomFileName());
            ListObjectsFile.Add(System.IO.Path.GetTempPath());
            ListObjectsFile.Add(System.IO.Path.GetTempFileName());
            ListObjectsFile.Add(System.IO.Path.Combine((string)(ListObjectsFile[3]), (string)(ListObjectsFile[5])));

            string ListFiles = "";
            for (int i = 0; i < ListObjectsFile.Count; i++)
            {
                ListFiles += String.Format("{0}\n \n", (string)ListObjectsFile[i]);
            }
            System.Windows.Forms.MessageBox.Show(ListFiles, "Files");

        }

        public string GET_GetDirectoryName(string File_Full_Patch)
        {
            if (Directory.Exists(File_Full_Patch))
            {
                File_Full_Patch = String.Format((@"{0}"), (Path.GetDirectoryName(File_Full_Patch)));
            }
            else if(!Directory.Exists(File_Full_Patch))
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