using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebookRepository.App.Controler.Tools
{
    class OpenFileDialogResult
    {
        public static string FileName()
        {
            var myReturn_String = (string.Empty);

            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
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
    }
}
