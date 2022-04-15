using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作业7_2
{
    public partial class Form1 : Form
    {
        int[] weight;
        string errorMsg;
        public Form1()
        {
            InitializeComponent();
            weight = new int[] { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
            errorMsg = "错误";
        }
        private bool check(string str)
        {
            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                sum += (str[i] - '0') * weight[i];
            }
            label2.Text = sum.ToString();
            sum = (12 - sum % 11) % 11;
            label2.Text += "    " + sum.ToString();
            if (sum == 10) return str[17] == 'x' || str[17] == 'X';
            return (sum == str[17] - '0');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regex = @"[1-9]{2}\d{4}(19|20)\d{2}[0|1][0-9][0-3][0-9]\d{3}[\d|x|X]\s*";
            string input = textBox1.Text;
            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(input, regex);
            if (!match.Success)
            {
                MessageBox.Show("身份证号格式不合法", "ERROR! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!check(input))
            {
                MessageBox.Show("身份证号验证错误", "ERROR! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                label2.Text = "身份证号合法正确。";
            }
        }
    }
}