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
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.textBox_File = new System.Windows.Forms.TextBox();
            this.groupBox_File = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_File.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(347, 45);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_Gravar.TabIndex = 0;
            this.btn_Gravar.Text = "&Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // textBox_File
            // 
            this.textBox_File.Location = new System.Drawing.Point(6, 19);
            this.textBox_File.Name = "textBox_File";
            this.textBox_File.Size = new System.Drawing.Size(416, 20);
            this.textBox_File.TabIndex = 1;
            // 
            // groupBox_File
            // 
            this.groupBox_File.Controls.Add(this.textBox_File);
            this.groupBox_File.Controls.Add(this.btn_Gravar);
            this.groupBox_File.Location = new System.Drawing.Point(12, 12);
            this.groupBox_File.Name = "groupBox_File";
            this.groupBox_File.Size = new System.Drawing.Size(428, 75);
            this.groupBox_File.TabIndex = 2;
            this.groupBox_File.TabStop = false;
            this.groupBox_File.Text = "Documento";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 245);
            this.dataGridView1.TabIndex = 3;
            // 
            // form_InsertFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 348);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox_File);
            this.Name = "form_InsertFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Documentos";
            this.groupBox_File.ResumeLayout(false);
            this.groupBox_File.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.TextBox textBox_File;
        private System.Windows.Forms.GroupBox groupBox_File;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}