namespace Rsa2Demo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.publicKey_txt = new System.Windows.Forms.TextBox();
            this.privateKey_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.str_txt = new System.Windows.Forms.TextBox();
            this.encrypt_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.decrypt_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sign_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "公钥";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "私钥";
            // 
            // publicKey_txt
            // 
            this.publicKey_txt.Location = new System.Drawing.Point(83, 20);
            this.publicKey_txt.Multiline = true;
            this.publicKey_txt.Name = "publicKey_txt";
            this.publicKey_txt.Size = new System.Drawing.Size(670, 60);
            this.publicKey_txt.TabIndex = 2;
            // 
            // privateKey_txt
            // 
            this.privateKey_txt.Location = new System.Drawing.Point(83, 86);
            this.privateKey_txt.Multiline = true;
            this.privateKey_txt.Name = "privateKey_txt";
            this.privateKey_txt.Size = new System.Drawing.Size(670, 56);
            this.privateKey_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "字符串";
            // 
            // str_txt
            // 
            this.str_txt.Location = new System.Drawing.Point(83, 150);
            this.str_txt.Multiline = true;
            this.str_txt.Name = "str_txt";
            this.str_txt.Size = new System.Drawing.Size(670, 52);
            this.str_txt.TabIndex = 5;
            // 
            // encrypt_txt
            // 
            this.encrypt_txt.Location = new System.Drawing.Point(83, 268);
            this.encrypt_txt.Multiline = true;
            this.encrypt_txt.Name = "encrypt_txt";
            this.encrypt_txt.Size = new System.Drawing.Size(670, 47);
            this.encrypt_txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "密文";
            // 
            // decrypt_txt
            // 
            this.decrypt_txt.Location = new System.Drawing.Point(83, 321);
            this.decrypt_txt.Multiline = true;
            this.decrypt_txt.Name = "decrypt_txt";
            this.decrypt_txt.Size = new System.Drawing.Size(670, 47);
            this.decrypt_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "解密";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "加密";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "解密";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(631, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 41);
            this.button3.TabIndex = 12;
            this.button3.Text = "验签";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(482, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 41);
            this.button4.TabIndex = 13;
            this.button4.Text = "签名";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sign_txt
            // 
            this.sign_txt.Location = new System.Drawing.Point(83, 210);
            this.sign_txt.Multiline = true;
            this.sign_txt.Name = "sign_txt";
            this.sign_txt.Size = new System.Drawing.Size(670, 52);
            this.sign_txt.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "签名";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sign_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.decrypt_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.encrypt_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.str_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.privateKey_txt);
            this.Controls.Add(this.publicKey_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rsa2Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox publicKey_txt;
        private System.Windows.Forms.TextBox privateKey_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox str_txt;
        private System.Windows.Forms.TextBox encrypt_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decrypt_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox sign_txt;
        private System.Windows.Forms.Label label6;
    }
}

