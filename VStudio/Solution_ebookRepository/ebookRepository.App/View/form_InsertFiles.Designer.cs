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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.F_CODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_EXTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_SIZE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_BYTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_File.SuspendLayout();
            this.groupBoxHASH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
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
            this.groupBoxHASH.Size = new System.Drawing.Size(259, 48);
            this.groupBoxHASH.TabIndex = 6;
            this.groupBoxHASH.TabStop = false;
            this.groupBoxHASH.Text = "Hash";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(193, 13);
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
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F_CODI,
            this.F_NAME,
            this.F_EXTE,
            this.F_SIZE,
            this.F_BYTE,
            this.F_TIME});
            this.dataGridView.Location = new System.Drawing.Point(12, 120);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(628, 144);
            this.dataGridView.TabIndex = 3;
            // 
            // F_CODI
            // 
            this.F_CODI.HeaderText = "Codigo";
            this.F_CODI.Name = "F_CODI";
            this.F_CODI.ReadOnly = true;
            // 
            // F_NAME
            // 
            this.F_NAME.HeaderText = "File Name";
            this.F_NAME.Name = "F_NAME";
            this.F_NAME.ReadOnly = true;
            // 
            // F_EXTE
            // 
            this.F_EXTE.HeaderText = "Extenção";
            this.F_EXTE.Name = "F_EXTE";
            this.F_EXTE.ReadOnly = true;
            // 
            // F_SIZE
            // 
            this.F_SIZE.HeaderText = "Tamanho";
            this.F_SIZE.Name = "F_SIZE";
            this.F_SIZE.ReadOnly = true;
            // 
            // F_BYTE
            // 
            this.F_BYTE.HeaderText = "byte";
            this.F_BYTE.Name = "F_BYTE";
            this.F_BYTE.ReadOnly = true;
            // 
            // F_TIME
            // 
            this.F_TIME.HeaderText = "DateTime";
            this.F_TIME.Name = "F_TIME";
            this.F_TIME.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_InsertFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox_File);
            this.Name = "form_InsertFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Documentos";
            this.groupBox_File.ResumeLayout(false);
            this.groupBox_File.PerformLayout();
            this.groupBoxHASH.ResumeLayout(false);
            this.groupBoxHASH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox textBox_File;
        private System.Windows.Forms.GroupBox groupBox_File;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox groupBoxHASH;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.CheckBox checkBoxMD5;
        private System.Windows.Forms.CheckBox checkBoxSHA256;
        private System.Windows.Forms.CheckBox checkBoxSHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_CODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_EXTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_SIZE;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_BYTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_TIME;
        private System.Windows.Forms.Button button1;
    }
}