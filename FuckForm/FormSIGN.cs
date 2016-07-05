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
    public partial class FormSIGN : Form
    {
        public FormSIGN()
        {
            InitializeComponent();
        }

        private void buttonSIGNcreatekeys_Click(object sender, EventArgs e)
        {
            string[] value = RSA.GenerateKeys();
            this.richTextBoxSIGNpvk.Text = value[0];
            this.richTextBoxSIGNpbk.Text = value[1];
        }

        private void buttonSIGNshowpvk_Click(object sender, EventArgs e)
        {
            this.richTextBoxSIGNpvk.Visible = true;

        }

        private void buttonSIGNMD5_Click(object sender, EventArgs e)
        {
            this.richTextBoxSIGNMD5.Text = MD5.MD5E(this.richTextBoxSIGNstr.Text);

        }

        private void buttonSIGNpvkE_Click(object sender, EventArgs e)
        {
            this.richTextBoxSIGNpvkE.Text = RSA.SignByRSA(this.richTextBoxSIGNMD5.Text, this.richTextBoxSIGNpvk.Text);

        }

        private void buttonSIGNpbkV_Click(object sender, EventArgs e)
        {
            this.richTextBoxSIGNpbkV.Text = RSA.IdentifyByRSA(this.richTextBoxSIGNpvkE.Text, this.richTextBoxSIGNpbk.Text);

        }

        private void buttonSIGNMD5V_Click(object sender, EventArgs e)
        {
            this.richTextBoxSIGNMD5result.Text = this.richTextBoxSIGNpbkV.Text.Equals(this.richTextBoxSIGNMD5.Text) ? "验证成功" : "验证失败";

        }
    }
}
