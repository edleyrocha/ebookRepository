using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using ebookRepository.App.Controler.Tools.Dialog;

using ebookRepository.App.Controler.Tools.DebugApp;




using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ebookRepository.App.Controler.ADO;
using ebookRepository.App.Controler.Tools;
using ebookRepository.App.Controler.Tools.Encoder;
using ebookRepository.App.Controler.Tools.HashFile;



using ebookRepository.App.Controler.Tools.Files;


namespace ebookRepository.App.View
{
    public partial class form_InsertFiles : Form
    {
        public form_InsertFiles()
        {
            InitializeComponent();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            LogAppMode.PrintTheLog();
            LogAppMode.PrintTheLog((sender as Button).Name + " [INICIO]");
            var File_Full_Patch = (OpenFile_Dialog.GET_File_Full_Patch());
            this.textBox_File.Text = (File_Full_Patch);
            LogAppMode.PrintTheLog((sender as Button).Name + " [GET_File_Full_Patch() ---> " + File_Full_Patch + "]",1);
            LogAppMode.PrintTheLog((sender as Button).Name + " [FINAL]");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            LogAppMode.PrintTheLog();
            LogAppMode.PrintTheLog((sender as Button).Name + " [INICIO]");
            if (!string.IsNullOrEmpty(this.textBox_File.Text))
            {
                LogAppMode.PrintTheLog((sender as Button).Name + " [CHECK ---> (!string.IsNullOrEmpty()) --> TRUE]", 1);
                if (File.Exists(this.textBox_File.Text))
                {
                    LogAppMode.PrintTheLog((sender as Button).Name + " [CHECK ---> (File.Exists()) --> TRUE]", 2);
                    var File_Full_Patch = (this.textBox_File.Text);
                    List<object> ListObjects = new List<object>();
                    ListObjects.Add(GET_FileName.GET_FileName_From_PatchFile(@File_Full_Patch: File_Full_Patch));
                    LogAppMode.PrintTheLog((sender as Button).Name + " [GET_FileName_From_PatchFile ---> " + (string)(ListObjects[0]) + "]", 3);
                }
                else
                {
                    LogAppMode.PrintTheLog((sender as Button).Name + " [CHECK ---> (File.Exists()) --> FALSE]", 2);
                }
            }
            else
            {
                LogAppMode.PrintTheLog((sender as Button).Name + " [CHECK ---> (!string.IsNullOrEmpty()) --> FALSE]", 1);
            }
            LogAppMode.PrintTheLog((sender as Button).Name + " [FIM]");

            //if ((string.IsNullOrEmpty(this.textBox_File.Text)) || ((File.Exists(this.textBox_File.Text))))
            //{
            //    MessageBox.Show("OK");

            //    //  this.textBox_File.Focus();
            //    //ListObjects.Add(GET_FileName.GET_FileName_From_PatchFile(ListObjects[0].ToString())); //1
            //    //ListObjects.Add(GET_DirectoryName.GET_DirectoryName_From_PatchFile(ListObjects[0].ToString())); //2
            //    //ListObjects.Add(DateTime.Now); //3
            //    //ListObjects.Add(ReadWriteFile.File_ReadAllBytes(ListObjects[0].ToString())); //4
            //    //ListObjects.Add(SaveFile_Dialog.SAVE_File_Full_Patch()); //5
            //}
        }

        private void groupBox_File_Enter(object sender, EventArgs e)
        {

        }
    }
}
