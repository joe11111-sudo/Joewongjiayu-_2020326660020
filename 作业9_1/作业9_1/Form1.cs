using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Random;
namespace 作业9_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int num;
        public int index = 0;
        public string word;
        public string meaning;
        public int correct = 0;
        private void vocabularies(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            string str;
            while ((str = sr.ReadLine()) != null)
            {

            }
            sr.Close();
        }
        string[] strl = new string[1409];
        public int i = 0;
        private void next_vocabulary(object sender, EventArgs e)
        {
            vocabulary.Text = "";
            indexs.Text = (index + 1).ToString();

            Random rd = new Random();
            int every = rd.Next(0, i);

            string[] temp = new string[3];
            temp = strl[every].Split(new Char[] { '\t', '\t', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            word = temp[0];
            meaning = temp[1];

            Chinese.Text = meaning;

            index++;

            next.Text = "skip";

        }

        private void start_Click(object sender, EventArgs e)
        {
            next.Enabled = true;
            Chinese.Text = "";

            this.next_vocabulary(sender, e);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            next.Enabled = false;
            StreamReader sr = new StreamReader("Vocabulary.txt", Encoding.Default);
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                strl[i] = str;
                i++;
            }

            Chinese.Text = "Total" + i.ToString() + "words";

            string[] temp = new string[3];
            temp = strl[0].Split(new Char[] { '\t', '\t', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (next.Text == "skip")
            {
                vocabulary.Text = word;
                vocabulary.Enabled = false;
                if (index == num)
                {
                    MessageBox.Show("total" + correct + "correct words");
                    next.Enabled = false;
                }
                next.Text = "next";
            }
            else
            {
                vocabulary.Enabled = true;
                this.next_vocabulary(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (vocabulary.Text == word)
            {
                MessageBox.Show("excellent!");
                correct++;
                num++;
                this.next_vocabulary(sender, e);
            }
            else
            {
                MessageBox.Show("try again!");
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)

        {

            if (e.KeyCode == Keys.Enter)

            {

                this.button1_Click(sender, e);

            }

        }
    }
}
