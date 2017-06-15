#region ---> [USING]

using System;
using System.IO;
using System.Windows.Forms;

#endregion

namespace ebookRepository.App.Controler.Tools.Dialog
{

    #region ---> [CLASS]

    class OpenFile_Dialog
    {

        #region ---> [METHODS]

        public static string GET_File_Full_Patch()
        {
            var OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Title = ("Adicionar Arquivo...");
            OpenFileDialog1.Filter = ("PDF Files(*.pdf) | *.pdf");
            OpenFileDialog1.InitialDirectory = (@"C:\USER\%username%\Desktop\");
            OpenFileDialog1.Multiselect = false;
            OpenFileDialog1.ShowReadOnly = true;
            OpenFileDialog1.ReadOnlyChecked = true;
            OpenFileDialog1.ShowHelp = true;
            OpenFileDialog1.ShowDialog();
            if (!(File.Exists(OpenFileDialog1.FileName)))
            {
                OpenFileDialog1.FileName = String.Empty;
            }
            return (OpenFileDialog1.FileName);
        }

        #endregion

    }

    #endregion

}
