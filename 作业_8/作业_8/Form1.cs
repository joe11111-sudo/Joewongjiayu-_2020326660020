using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace 作业_8
{
    public partial class Form1 : Form
    {
        private delegate void MyDelegate();
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task task_baidu = new Task(() => { Search_baidu("https://www.baidu.com/baidu?wd=" + textBox1.Text); });    
            task_baidu.Start();
        }

        private void Search_baidu(string url)
        {
            WebClient webClient = new WebClient();
            byte[] recvdata = webClient.DownloadData(url);       // 指定url下载数据到byte数组中
            string response = Encoding.UTF8.GetString(recvdata); // 获取UTF-8类型编码
            this.BeginInvoke(new MyDelegate(() => { textBox2.Text = response.Substring(0, 200); }));   // 将转换后的数据填入textBox

        }

    }
}
