
namespace 作业5_3
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
            this.openfile = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.readpath = new System.Windows.Forms.Button();
            this.openfile2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(101, 151);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(94, 29);
            this.openfile.TabIndex = 0;
            this.openfile.Text = "文件1";
            this.openfile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 186);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 259);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 23);
            this.textBox2.TabIndex = 4;
            // 
            // readpath
            // 
            this.readpath.Location = new System.Drawing.Point(334, 150);
            this.readpath.Name = "readpath";
            this.readpath.Size = new System.Drawing.Size(94, 29);
            this.readpath.TabIndex = 5;
            this.readpath.Text = "merge";
            this.readpath.UseVisualStyleBackColor = true;
            this.readpath.Click += new System.EventHandler(this.readpath_Click);
            // 
            // openfile2
            // 
            this.openfile2.Location = new System.Drawing.Point(101, 224);
            this.openfile2.Name = "openfile2";
            this.openfile2.Size = new System.Drawing.Size(94, 29);
            this.openfile2.TabIndex = 6;
            this.openfile2.Text = "文件2";
            this.openfile2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.openfile2.UseVisualStyleBackColor = true;
            this.openfile2.Click += new System.EventHandler(this.openfile2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(334, 214);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(306, 23);
            this.textBox3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.openfile2);
            this.Controls.Add(this.readpath);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.openfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button readpath;
        private System.Windows.Forms.Button openfile2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

