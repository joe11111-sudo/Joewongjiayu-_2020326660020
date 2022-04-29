
namespace 作业9_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.indexs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Chinese = new System.Windows.Forms.Label();
            this.vocabulary = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
          
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(24, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "请输入您想要背的单词数：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "第";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Words：";
            // 
            // indexs
            // 
            this.indexs.Location = new System.Drawing.Point(35, 146);
            this.indexs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.indexs.Name = "indexs";
            this.indexs.Size = new System.Drawing.Size(28, 22);
            this.indexs.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(30, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(385, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "请输入以下中文对应的英文单词：";
            // 
            // Chinese
            // 
            this.Chinese.AutoSize = true;
            this.Chinese.Location = new System.Drawing.Point(32, 285);
            this.Chinese.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Chinese.Name = "Chinese";
            this.Chinese.Size = new System.Drawing.Size(0, 17);
            this.Chinese.TabIndex = 12;
            // 
            // vocabulary
            // 
            this.vocabulary.Location = new System.Drawing.Point(425, 212);
            this.vocabulary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vocabulary.Multiline = true;
            this.vocabulary.Name = "vocabulary";
            this.vocabulary.Size = new System.Drawing.Size(202, 34);
            this.vocabulary.TabIndex = 13;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(508, 83);
            this.start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(103, 41);
            this.start.TabIndex = 14;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(508, 302);
            this.next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(103, 41);
            this.next.TabIndex = 15;
            this.next.Text = "请显示答案";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.vocabulary);
            this.panel1.Controls.Add(this.Chinese);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.indexs);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 437);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 453);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "背单词小助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox indexs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Chinese;
        private System.Windows.Forms.TextBox vocabulary;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

