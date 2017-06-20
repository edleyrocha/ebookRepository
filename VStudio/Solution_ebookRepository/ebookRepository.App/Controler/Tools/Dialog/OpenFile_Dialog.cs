#region ---> [USING]

using System;
using System.IO;
using System.Windows.Forms;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Tools.Dialog
{

    #region ---> [CLASS]

    class OpenFile_Dialog : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~OpenFile_Dialog()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        public string GET_OpenFile_Dialog()
        {
            using (var _OpenFileDialog = new OpenFileDialog())
            {
                _OpenFileDialog.Title = ("Adicionar Arquivo...");
                _OpenFileDialog.Filter = ("PDF Files(*.pdf) | *.pdf");
                _OpenFileDialog.InitialDirectory = (@"C:\USER\%username%\Desktop\");
                _OpenFileDialog.Multiselect = false;
                _OpenFileDialog.ShowReadOnly = true;
                _OpenFileDialog.ReadOnlyChecked = true;
                _OpenFileDialog.ShowHelp = true;
                _OpenFileDialog.ShowDialog();
                if (!File.Exists(_OpenFileDialog.FileName))
                {
                    _OpenFileDialog.FileName = (string.Empty);
                }
                return (_OpenFileDialog.FileName);
            }
        }

        #endregion

    }

    #endregion

}

#endregion