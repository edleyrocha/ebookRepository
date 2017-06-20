#region ---> [USING]

using System;
using System.Windows.Forms;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Tools.Dialog
{

    #region ---> [CLASS]

    class SaveFile_Dialog : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~SaveFile_Dialog()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        public string SAVE_File_Full_Patch()
        {
            var SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Title = ("Salvar Arquivo...");
            SaveFileDialog1.Filter = ("PDF Files(*.pdf) | *.pdf");
            SaveFileDialog1.InitialDirectory = (@"C:\USER\%username%\Desktop\");
             SaveFileDialog1.ShowHelp = true;
            SaveFileDialog1.ShowDialog();
            return (SaveFileDialog1.FileName);
        }

        #endregion

    }

    #endregion

}

#endregion