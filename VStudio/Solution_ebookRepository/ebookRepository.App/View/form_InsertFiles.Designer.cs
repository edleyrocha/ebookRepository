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
            this.F_SIZE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHA256 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.textBox_Find = new System.Windows.Forms.TextBox();
            this.groupBox_Find = new System.Windows.Forms.GroupBox();
            this.listView_Base = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_File.SuspendLayout();
            this.groupBoxHASH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox_Find.SuspendLayout();
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
            this.F_SIZE,
            this.F_TIME,
            this.MD5,
            this.SHA1,
            this.SHA256});
            this.dataGridView.Location = new System.Drawing.Point(12, 120);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(634, 144);
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
            // F_SIZE
            // 
            this.F_SIZE.HeaderText = "Tamanho";
            this.F_SIZE.Name = "F_SIZE";
            this.F_SIZE.ReadOnly = true;
            // 
            // F_TIME
            // 
            this.F_TIME.HeaderText = "DateTime";
            this.F_TIME.Name = "F_TIME";
            this.F_TIME.ReadOnly = true;
            // 
            // MD5
            // 
            this.MD5.HeaderText = "MD5";
            this.MD5.Name = "MD5";
            this.MD5.ReadOnly = true;
            // 
            // SHA1
            // 
            this.SHA1.HeaderText = "SHA1";
            this.SHA1.Name = "SHA1";
            this.SHA1.ReadOnly = true;
            // 
            // SHA256
            // 
            this.SHA256.HeaderText = "SHA256";
            this.SHA256.Name = "SHA256";
            this.SHA256.ReadOnly = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(119, 44);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 50);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Find
            // 
            this.textBox_Find.Location = new System.Drawing.Point(10, 19);
            this.textBox_Find.Name = "textBox_Find";
            this.textBox_Find.Size = new System.Drawing.Size(184, 20);
            this.textBox_Find.TabIndex = 5;
            // 
            // groupBox_Find
            // 
            this.groupBox_Find.Controls.Add(this.textBox_Find);
            this.groupBox_Find.Controls.Add(this.btnListar);
            this.groupBox_Find.Location = new System.Drawing.Point(446, 14);
            this.groupBox_Find.Name = "groupBox_Find";
            this.groupBox_Find.Size = new System.Drawing.Size(200, 100);
            this.groupBox_Find.TabIndex = 6;
            this.groupBox_Find.TabStop = false;
            this.groupBox_Find.Text = "Procurar";
            // 
            // listView_Base
            // 
            this.listView_Base.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_Base.GridLines = true;
            this.listView_Base.Location = new System.Drawing.Point(12, 270);
            this.listView_Base.Name = "listView_Base";
            this.listView_Base.Size = new System.Drawing.Size(634, 182);
            this.listView_Base.TabIndex = 7;
            this.listView_Base.UseCompatibleStateImageBehavior = false;
            this.listView_Base.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 141;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tamanho";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MD5";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SHA1";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "SHA256";
            // 
            // form_InsertFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 464);
            this.Controls.Add(this.listView_Base);
            this.Controls.Add(this.groupBox_Find);
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
            this.groupBox_Find.ResumeLayout(false);
            this.groupBox_Find.PerformLayout();
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
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox textBox_Find;
        private System.Windows.Forms.GroupBox groupBox_Find;
        private System.Windows.Forms.ListView listView_Base;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_CODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_SIZE;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHA256;
    }
}