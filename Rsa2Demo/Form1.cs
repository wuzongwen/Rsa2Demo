using RSAHelper;
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

namespace Rsa2Demo
{
    public partial class Form1 : Form
    {
        private readonly Helper rsa;
        public Form1()
        {
            InitializeComponent();

            publicKey_txt.Text = Helper.ReadPublicKey($"{Application.StartupPath}\\Keys\\app_public_key.pem");

            privateKey_txt.Text = Helper.ReadPrivateKey($"{Application.StartupPath}\\Keys\\app_private_key.pem");

            //2048 公钥
            string publicKey = publicKey_txt.Text;
            //2048 私钥
            string privateKey = privateKey_txt.Text;

            rsa = new Helper(RSAType.RSA2, Encoding.UTF8, privateKey, publicKey);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = str_txt.Text.Trim();
            if (string.IsNullOrWhiteSpace(str)) 
            {
                MessageBox.Show("请输入待加密的字符串");
                return;
            }

            //加密
            string enStr = rsa.Encrypt(str);
            if (enStr == null)
            {
                MessageBox.Show("加密失败");
                return;
            }
            encrypt_txt.Text = enStr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string enStr = encrypt_txt.Text;
            if (string.IsNullOrWhiteSpace(enStr))
            {
                MessageBox.Show("请先加密");
                return;
            }

            //解密
            string deStr = rsa.Decrypt(enStr);
            if (deStr == null) 
            {
                MessageBox.Show("解密失败");
                return;
            }
            decrypt_txt.Text = deStr;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = str_txt.Text.Trim();
            if (string.IsNullOrWhiteSpace(str))
            {
                MessageBox.Show("请输入待加密的字符串");
                return;
            }

            //私钥签名
            string signStr = rsa.Sign(str);

            sign_txt.Text = signStr;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = str_txt.Text.Trim();
            if (string.IsNullOrWhiteSpace(str))
            {
                MessageBox.Show("请输入待加密的字符串");
                return;
            }
            string signStr = sign_txt.Text;
            if (string.IsNullOrWhiteSpace(str))
            {
                MessageBox.Show("请先对字符串签名");
                return;
            }

            //公钥验证签名
            bool signVerify = rsa.Verify(str, signStr);

            if (signVerify) 
            {
                MessageBox.Show("验签通过");
                return;
            }
            MessageBox.Show("验签失败");
        }
    }
}
