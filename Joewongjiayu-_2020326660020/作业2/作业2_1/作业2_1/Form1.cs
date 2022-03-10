using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//b1. 编写程序输出用户指定数据的所有素数因子。

namespace 作业2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            try
            {
                int param = int.Parse(textBox1.Text);

                if (param <= 1)
                {
                    textBoxResult.Text = "1";
                }
                for (int i = 2; i < param; i++)
                {
                    if (param % i == 0)
                        textBoxResult.Text += string.Format(i.ToString() + "  ");
                }
            }
            catch (Exception err)
            {
                textBoxResult.Text += " error" + err.Message + Environment.NewLine;
            }
            finally
            {
                textBoxResult.Text += " bye" + Environment.NewLine;
            }
        

         }
    }
}
