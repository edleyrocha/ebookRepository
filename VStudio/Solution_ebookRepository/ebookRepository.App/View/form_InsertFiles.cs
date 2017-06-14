using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ebookRepository.App.Controler.ADO;
using ebookRepository.App.Controler.Tools;
using ebookRepository.App.Controler.Tools.Encoder;
using ebookRepository.App.Controler.Tools.HashFile;

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
            List<object> ListObjects = new List<object>();
            ListObjects.Add(textBox_File.Text = (OpenFileDialogResult.FileName()));
           
            var File_Full_Patch = (textBox_File.Text);
            var FileName = (GetFileName.GetFileName_From_PatchFile(@File_Full_Patch: File_Full_Patch));



            ////var CheckSumMD5 = GetHashCheckSum.ReturnMD5(@File_Full_Patch: File_Full_Patch);
            ////var CheckSumSHA1 = GetHashCheckSum.ReturnSHA1(@File_Full_Patch: File_Full_Patch);
            ////var CheckSumSHA256 = GetHashCheckSum.ReturnSHA256(@File_Full_Patch: File_Full_Patch);


            
            //ListObjects.Add(FileName);
            //ListObjects.Add(CheckSumMD5);
            //ListObjects.Add(CheckSumSHA1);
            //ListObjects.Add(CheckSumSHA256);

            MessageBox.Show
                (
                    (ListObjects[0].ToString()).Length.ToString() + " " + (ListObjects[0].ToString()) + "\n"
                   // (ListObjects[2].ToString()).Length.ToString() + " " + (ListObjects[2].ToString()) + "\n" +
                 //   (ListObjects[3].ToString()).Length.ToString() + " " + (ListObjects[3].ToString()) + "\n"
                );

            //Object[] Objects_Array = new object[5];

            //Objects_Array[0] = (FileName);
            //Objects_Array[1] = (CheckSumMD5);
            //Objects_Array[2] = (CheckSumSHA1);
            //Objects_Array[3] = (CheckSumSHA256);
            //MessageBox.Show
            //    (
            //        (Objects_Array[1].ToString()).Length.ToString() +" "+ (Objects_Array[1].ToString()) + "\n" +
            //        (Objects_Array[2].ToString()).Length.ToString() + " " + (Objects_Array[2].ToString()) + "\n" +
            //        (Objects_Array[3].ToString()).Length.ToString() + " " + (Objects_Array[3].ToString()) + "\n"  
            //    );

        }

        private void groupBox_File_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_File_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_InsertFiles_Load(object sender, EventArgs e)
        {

        }
    }
}
