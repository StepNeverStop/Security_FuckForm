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
    public partial class FormAES : Form
    {
        public FormAES()
        {
            InitializeComponent();
        }

        private void buttonAESshowkey_Click(object sender, EventArgs e)
        {
            this.labelAESshowkey.Text = textBoxAESkey.Text;
            this.labelAESshowkey.Visible = true;
        }

        private void buttonAESE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAESkey.Text))
                this.richTextBoxAESE.Text = AES.Encrypt(richTextBoxAESstr.Text);
            else
                this.richTextBoxAESE.Text = AES.Encrypt(richTextBoxAESstr.Text, textBoxAESkey.Text);
        }

        private void buttonAESD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAESkey.Text))
                this.richTextBoxAESD.Text = AES.Decrypt(richTextBoxAESE.Text);
            else
                this.richTextBoxAESD.Text = AES.Decrypt(richTextBoxAESE.Text, textBoxAESkey.Text);
        }
    }
}
