using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ebookRepository.App.Controler.Database;
namespace ebookRepository.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[] aaa = null;
        string bbb = null;
        private void button1_Click(object sender, EventArgs e)
        {
            aaa = SQLite_HexPassword.Get_Bytes_from_String(textBox1.Text);
         
            richTextBox1.Text = SQLite_HexPassword.GetHex_to_Bytes(aaa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
             bbb = SQLite_HexPassword.Get_String_from_Bytes(aaa);

            richTextBox1.Text = bbb;
        }
    }
}
