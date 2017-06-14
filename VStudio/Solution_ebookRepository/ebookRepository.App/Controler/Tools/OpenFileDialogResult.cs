#region ---> [USING]

using System;
using System.Windows.Forms;

#endregion

namespace ebookRepository.App.Controler.Tools
{

    #region ---> [CLASS]

    class OpenFileDialogResult
    {

        #region ---> [METHODS]

        public static string FileName()
        {
            var myReturn_String = (string.Empty);

            var OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = ("PDF Files(*.pdf) | *.pdf");
            OpenFileDialog1.InitialDirectory= (@"C:\USER\%username%\Desktop\");
            OpenFileDialog1.Multiselect = false;

            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myReturn_String = (OpenFileDialog1.FileName);
            }
            else 
            {
                myReturn_String = (string.Empty);
            }
             return (myReturn_String);
        }

        #endregion

    }

    #endregion

}
