using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuckForm
{
    public partial class FormSIGN2 : Form
    {
        public FormSIGN2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] keys = RSA.GenerateKeys();
            CA.CARSAprivateKey = keys[0];
            CA.CARSApublicKey = keys[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] keys = RSA.GenerateKeys();
            Credential.privatekey = keys[0];
            Credential.publickey = keys[1];
            Credential.timenow = DateTime.Now;
            Credential.timeto = Credential.timenow.AddYears(2);
            Credential.user = "服务器";
            vs.vstring = Credential.user + Credential.timenow;
            Credential.casign = RSA.SignByRSA(vs.vstring, CA.CARSAprivateKey);

            FormCredential fcre = new FormCredential();
            fcre.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox2.Text = RSA.SignByRSA(DES.DESEncrypt(this.richTextBox1.Text, "12345678"), Credential.privatekey);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(DateTime.Now>Credential.timeto)
            {
                this.textBox1.Text = "证书已过期";
                return;
            }
            if (vs.vstring.Equals(RSA.IdentifyByRSA(Credential.casign, CA.CARSApublicKey)))
                this.textBox1.Text = "有效";
            else
                this.textBox1.Text = "无效";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch(this.textBox1.Text)
            {
                case "证书已过期":
                    this.richTextBox3.Text = "过期了就别解密了，呆着去吧！";
                    break;
                case "有效":
                    this.richTextBox3.Text = DES.DESDecrypt(RSA.IdentifyByRSA(this.richTextBox2.Text, Credential.publickey), "12345678");
                    break;
                case "无效":
                    this.richTextBox3.Text = "证书验证失败";
                    break;
                default:
                    break;
            }
        }
    }
}
