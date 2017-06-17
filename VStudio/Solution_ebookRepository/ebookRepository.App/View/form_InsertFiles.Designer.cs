namespace ebookRepository.App.View
{
    partial class form_InsertFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcurar = new System.Windows.Forms.Button();
            this.textBox_File = new System.Windows.Forms.TextBox();
            this.groupBox_File = new System.Windows.Forms.GroupBox();
            this.groupBoxHASH = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.checkBoxMD5 = new System.Windows.Forms.CheckBox();
            this.checkBoxSHA256 = new System.Windows.Forms.CheckBox();
            this.checkBoxSHA1 = new System.Windows.Forms.CheckBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_File.SuspendLayout();
            this.groupBoxHASH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(347, 16);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 25);
            this.btnProcurar.TabIndex = 0;
            this.btnProcurar.Text = "&Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // textBox_File
            // 
            this.textBox_File.Location = new System.Drawing.Point(6, 19);
            this.textBox_File.Name = "textBox_File";
            this.textBox_File.Size = new System.Drawing.Size(335, 20);
            this.textBox_File.TabIndex = 1;
            // 
            // groupBox_File
            // 
            this.groupBox_File.Controls.Add(this.groupBoxHASH);
            this.groupBox_File.Controls.Add(this.btnGravar);
            this.groupBox_File.Controls.Add(this.textBox_File);
            this.groupBox_File.Controls.Add(this.btnProcurar);
            this.groupBox_File.Location = new System.Drawing.Point(12, 12);
            this.groupBox_File.Name = "groupBox_File";
            this.groupBox_File.Size = new System.Drawing.Size(428, 102);
            this.groupBox_File.TabIndex = 2;
            this.groupBox_File.TabStop = false;
            this.groupBox_File.Text = "Documento";
            // 
            // groupBoxHASH
            // 
            this.groupBoxHASH.Controls.Add(this.btnCheck);
            this.groupBoxHASH.Controls.Add(this.checkBoxMD5);
            this.groupBoxHASH.Controls.Add(this.checkBoxSHA256);
            this.groupBoxHASH.Controls.Add(this.checkBoxSHA1);
            this.groupBoxHASH.Location = new System.Drawing.Point(6, 48);
            this.groupBoxHASH.Name = "groupBoxHASH";
            this.groupBoxHASH.Size = new System.Drawing.Size(335, 48);
            this.groupBoxHASH.TabIndex = 6;
            this.groupBoxHASH.TabStop = false;
            this.groupBoxHASH.Text = "Hash";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(276, 15);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(53, 25);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // checkBoxMD5
            // 
            this.checkBoxMD5.AutoSize = true;
            this.checkBoxMD5.Location = new System.Drawing.Point(6, 19);
            this.checkBoxMD5.Name = "checkBoxMD5";
            this.checkBoxMD5.Size = new System.Drawing.Size(49, 17);
            this.checkBoxMD5.TabIndex = 3;
            this.checkBoxMD5.Text = "MD5";
            this.checkBoxMD5.UseVisualStyleBackColor = true;
            this.checkBoxMD5.CheckedChanged += new System.EventHandler(this.checkBoxMD5_CheckedChanged);
            // 
            // checkBoxSHA256
            // 
            this.checkBoxSHA256.AutoSize = true;
            this.checkBoxSHA256.Location = new System.Drawing.Point(121, 19);
            this.checkBoxSHA256.Name = "checkBoxSHA256";
            this.checkBoxSHA256.Size = new System.Drawing.Size(66, 17);
            this.checkBoxSHA256.TabIndex = 4;
            this.checkBoxSHA256.Text = "SHA256";
            this.checkBoxSHA256.UseVisualStyleBackColor = true;
            this.checkBoxSHA256.CheckedChanged += new System.EventHandler(this.checkBoxSHA256_CheckedChanged);
            // 
            // checkBoxSHA1
            // 
            this.checkBoxSHA1.AutoSize = true;
            this.checkBoxSHA1.Location = new System.Drawing.Point(61, 19);
            this.checkBoxSHA1.Name = "checkBoxSHA1";
            this.checkBoxSHA1.Size = new System.Drawing.Size(54, 17);
            this.checkBoxSHA1.TabIndex = 5;
            this.checkBoxSHA1.Text = "SHA1";
            this.checkBoxSHA1.UseVisualStyleBackColor = true;
            this.checkBoxSHA1.CheckedChanged += new System.EventHandler(this.checkBoxSHA1_CheckedChanged);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(347, 48);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 50);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 144);
            this.dataGridView1.TabIndex = 3;
            // 
            // form_InsertFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 271);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox_File);
            this.Name = "form_InsertFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Documentos";
            this.groupBox_File.ResumeLayout(false);
            this.groupBox_File.PerformLayout();
            this.groupBoxHASH.ResumeLayout(false);
            this.groupBoxHASH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox textBox_File;
        private System.Windows.Forms.GroupBox groupBox_File;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox groupBoxHASH;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.CheckBox checkBoxMD5;
        private System.Windows.Forms.CheckBox checkBoxSHA256;
        private System.Windows.Forms.CheckBox checkBoxSHA1;
    }
}