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
    public partial class FormRSA : Form
    {
        public FormRSA()
        {
            InitializeComponent();
        }

        private void buttonRSACreateKeys_Click(object sender, EventArgs e)
        {
            string[] keys = RSA.GenerateKeys();
            this.richTextBoxRSAshowpvk.Text = keys[0];
            this.richTextBoxRSAshowpbk.Text = keys[1];
            this.richTextBoxRSAshowpbk.Visible = true;
            this.buttonRSAshowpvk.Visible = true;
        }

        private void buttonRSAshowpvk_Click(object sender, EventArgs e)
        {
            this.richTextBoxRSAshowpvk.Visible = true;

        }

        private void buttonRSApkeyE_Click(object sender, EventArgs e)
        {
            this.richTextBoxRSApkeyE.Text = RSA.EncryptByRSA(this.richTextBoxRSAstr.Text, this.richTextBoxRSAshowpbk.Text);

        }

        private void buttonRSApkeyD_Click(object sender, EventArgs e)
        {
            this.richTextBoxRSApkeyD.Text = RSA.DecryptByRSA(this.richTextBoxRSApkeyE.Text, this.richTextBoxRSAshowpvk.Text);

        }
    }
}
