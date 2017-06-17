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
using ebookRepository.App.Controler.Database;

namespace ebookRepository.App.View
{
    public partial class form_InsertFiles : Form
    {
        public form_InsertFiles()
        {
            InitializeComponent();
            btnCheck.Enabled = (false);
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
     
            LogAppMode.PrintTheLog();
            LogAppMode.PrintTheLog((sender as Button).Name + " [INICIO]");
            checkBoxMD5.Tag = (string.Empty);
            checkBoxSHA1.Tag = (string.Empty);
            checkBoxSHA256.Tag = (string.Empty);
            var File_Full_Patch = (OpenFile_Dialog.GET_File_Full_Patch());
            this.textBox_File.Text = (File_Full_Patch);
            LogAppMode.PrintTheLog((sender as Button).Name + " [FINAL]");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            LogAppMode.PrintTheLog();
            LogAppMode.PrintTheLog((sender as Button).Name + " [INICIO]");
            if (!string.IsNullOrEmpty(this.textBox_File.Text))
            {
                if (File.Exists(this.textBox_File.Text))
                {
                    var File_Full_Patch = (this.textBox_File.Text);

                    List<object> ListObjects = new List<object>();
                    ListObjects.Add(Check_FileName.GET_FileNameWithoutExtension(@File_Full_Patch: File_Full_Patch));
                    ListObjects.Add(Check_FileName.GET_FileNameExtensions(@File_Full_Patch: File_Full_Patch));
                    ListObjects.Add(ReadWriteFile.File_ReadAllBytes(@File_Full_Patch: File_Full_Patch));
                    ListObjects.Add(DateTime.Now);
                    ListObjects.Add(checkBoxMD5.Tag.ToString());
                    ListObjects.Add(checkBoxSHA1.Tag.ToString());
                    ListObjects.Add(checkBoxSHA256.Tag.ToString());


                    StringBuilder MessageText = new StringBuilder();
                    MessageText.AppendLine(string.Format("0 {0}", (ListObjects[0].ToString())));
                    MessageText.AppendLine(string.Format("1 {0}", (ListObjects[1].ToString())));
                    MessageText.AppendLine(string.Format("2 {0}", (ListObjects[2].ToString())));
                    MessageText.AppendLine(string.Format("3 {0}", (ListObjects[3].ToString())));
                    MessageText.AppendLine(string.Format("4 {0}", (ListObjects[4].ToString())));
                    MessageText.AppendLine(string.Format("5 {0}", (ListObjects[5].ToString())));
                    MessageText.AppendLine(string.Format("6 {0}", (ListObjects[6].ToString())));
                    MessageBox.Show(MessageText.ToString());
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
        }
        private void CheckBox_CheckStatus()
        {
            if ((checkBoxMD5.Checked) || (checkBoxSHA1.Checked) || (checkBoxSHA256.Checked))
            {
                btnCheck.Enabled = (true);
            }
            else
            {
                btnCheck.Enabled = (false);
            }
        }
        private void Check_Hash()
        {
            StringBuilder MessageText = new StringBuilder();
            if (checkBoxMD5.Checked)
            {
                checkBoxMD5.Tag = (HashCheckSum.ReturnMD5(textBox_File.Text));
                MessageText.AppendLine(string.Format("MD5 \n{0}", (checkBoxMD5.Tag.ToString())));
            };
            if (checkBoxSHA1.Checked)
            {
                checkBoxSHA1.Tag = (HashCheckSum.ReturnSHA1(textBox_File.Text));
                MessageText.AppendLine(string.Format("SHA1 \n{0}", (checkBoxSHA1.Tag.ToString())));
            };
            if (checkBoxSHA256.Checked)
            {
                checkBoxSHA256.Tag = (HashCheckSum.ReturnSHA256(textBox_File.Text));
                MessageText.AppendLine(string.Format("SHA256 \n{0}", (checkBoxSHA256.Tag.ToString())));
            };
            MessageBox.Show(MessageText.ToString());
        }


        private void checkBoxMD5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckStatus();
        }

        private void checkBoxSHA1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckStatus();
        }

        private void checkBoxSHA256_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckStatus();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Check_Hash();
        }
    }
}
