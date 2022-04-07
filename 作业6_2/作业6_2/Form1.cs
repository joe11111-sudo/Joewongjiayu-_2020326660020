using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作业6_2
{
    public partial class Form1 : Form
    {
        Boolean b = true;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "文本框";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(b == true)
            {
                textBox1.SelectAll();
                label1.Text = textBox1.SelectedText;
            }
  
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 10;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
