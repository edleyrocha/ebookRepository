using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using ebookRepository.App.Controler.Tools.Dialog;
using ebookRepository.App.Controler.Tools.Files;
using ebookRepository.App.Controler.Tools.HashFile;
using System.Data;

namespace ebookRepository.App.View
{
    public partial class form_InsertFiles : Form
    {
        public form_InsertFiles()
        {
            InitializeComponent();
            btnCheck.Enabled = (false);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            using (var _OpenFile_Dialog = new OpenFile_Dialog())
            {
                checkBoxMD5.Tag = (string.Empty);
                checkBoxSHA1.Tag = (string.Empty);
                checkBoxSHA256.Tag = (string.Empty);
                this.textBox_File.Text = (_OpenFile_Dialog.GET_OpenFile_Dialog());
            };
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox_File.Text))
            {
                if (File.Exists(this.textBox_File.Text))
                {
                    var File_Full_Patch = (this.textBox_File.Text);

                    List<object> ListObjects = new List<object>();
                    ListObjects.Add(new Check_FileName().GET_FileNameWithoutExtension(@File_Full_Patch: File_Full_Patch));
                    ListObjects.Add(new Check_FileName().GET_FileNameExtensions(@File_Full_Patch: File_Full_Patch));
                    ListObjects.Add(new GetFileSizeInBytes().GetSizeFile(@File_Full_Patch: File_Full_Patch));
                    ListObjects.Add(new ReadWriteFile().File_ReadAllBytes(@File_Full_Patch: File_Full_Patch));
                    ListObjects.Add(DateTime.Now.ToString());

                    ListObjects.Add("SEM_HASH_MD5");
                    if ((checkBoxMD5.Checked) && (!String.IsNullOrEmpty(checkBoxMD5.Tag.ToString())))
                    {
                        ListObjects[5] = (checkBoxMD5.Tag.ToString());
                    }

                    ListObjects.Add("SEM_HASH_SHA1");
                    if ((checkBoxSHA1.Checked) && (!String.IsNullOrEmpty(checkBoxSHA1.Tag.ToString())))
                    {
                        ListObjects[6] = (checkBoxSHA1.Tag.ToString());
                    }

                    ListObjects.Add("SEM_HASH_SHA256");
                    if ((checkBoxSHA256.Checked) && (!String.IsNullOrEmpty(checkBoxSHA256.Tag.ToString())))
                    {
                        ListObjects[7] = (checkBoxSHA256.Tag.ToString());
                    }

                    StringBuilder MessageText = new StringBuilder();

                    for (int i = 0; i < ListObjects.Count; i++)
                    {
                        MessageText.AppendLine(string.Format("{0} {1}", ((i).ToString()), (ListObjects[i].ToString())));
                    }
                    DialogResult dialogResult = MessageBox.Show((MessageText.ToString()), "Insert", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        new ebookRepository.App.Controler.ADO.SQLite_Default_Execute_InsertFile().Execute(@ListObjects: ListObjects);
                    };


                }
                else
                {
                    new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog((sender as Button).Name + " [CHECK ---> (File.Exists()) --> FALSE]", 2);
                }
            }
            else
            {
                new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog((sender as Button).Name + " [CHECK ---> (!string.IsNullOrEmpty()) --> FALSE]", 1);
            }
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
            if (File.Exists(textBox_File.Text))
            {
                StringBuilder MessageText = new StringBuilder();
                if (checkBoxMD5.Checked)
                {
                    using (var _HashCheckSum = (new HashCheckSum()))
                    {
                        checkBoxMD5.Tag = (_HashCheckSum.ReturnMD5(textBox_File.Text));
                        MessageText.AppendLine(string.Format("MD5 \n{0}", (checkBoxMD5.Tag.ToString())));
                    };
                };
                if (checkBoxSHA1.Checked)
                {
                    using (var _HashCheckSum = (new HashCheckSum()))
                    {
                        checkBoxSHA1.Tag = (_HashCheckSum.ReturnSHA1(textBox_File.Text));
                        MessageText.AppendLine(string.Format("SHA1 \n{0}", (checkBoxSHA1.Tag.ToString())));
                    };
                };
                if (checkBoxSHA256.Checked)
                {
                    using (var _HashCheckSum = (new HashCheckSum()))
                    {
                        checkBoxSHA256.Tag = (_HashCheckSum.ReturnSHA256(textBox_File.Text));
                        MessageText.AppendLine(string.Format("SHA256 \n{0}", (checkBoxSHA256.Tag.ToString())));
                    };
                };
                MessageBox.Show(MessageText.ToString());
            };
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

        private void button1_Click(object sender, EventArgs e)
        {
            var FileName = (textBox_Find.Text);
            using (var _DataTable = new ebookRepository.App.Controler.ADO.SQLite_Default_Execute_GetDatasetFiles().Execute())
            {
                dataGridView.Rows.Clear();
                for (int i = 0; i < _DataTable.Rows.Count; i++)
                {
                    var F_CODI = _DataTable.Rows[i].ItemArray[0].ToString();
                    var F_NAME = _DataTable.Rows[i].ItemArray[1].ToString();
                    var F_SIZE = _DataTable.Rows[i].ItemArray[2].ToString();
                    var F_TIME = _DataTable.Rows[i].ItemArray[3].ToString();
                    var MD5 = _DataTable.Rows[i].ItemArray[4].ToString();
                    var SHA1 = _DataTable.Rows[i].ItemArray[5].ToString();
                    var SHA256 = _DataTable.Rows[i].ItemArray[6].ToString();
                    dataGridView.Rows.Add(F_CODI, F_NAME, F_SIZE, F_TIME, MD5, SHA1, SHA256);
                }

            }
            using (var _SQLiteDataReader = new ebookRepository.App.Controler.ADO.SQLite_Default_Execute_GetDatasetFiles().Execute(FileName))
            {
                listView_Base.Items.Clear();
                while (_SQLiteDataReader.Read())
                {
                    ListViewItem list = new ListViewItem(_SQLiteDataReader[0].ToString());
                    list.SubItems.Add(_SQLiteDataReader[1].ToString());
                    list.SubItems.Add(_SQLiteDataReader[2].ToString());
                    list.SubItems.Add(_SQLiteDataReader[3].ToString());
                    list.SubItems.Add(_SQLiteDataReader[4].ToString());
                    list.SubItems.Add(_SQLiteDataReader[5].ToString());
                    list.SubItems.Add(_SQLiteDataReader[6].ToString());
                    listView_Base.Items.AddRange(new ListViewItem[] { list });
                }
            }




        }
    }
}

