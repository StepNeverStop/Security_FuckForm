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
    public partial class FormDES : Form
    {
        public FormDES()
        {
            InitializeComponent();
        }

        private void FormDES_Load(object sender, EventArgs e)
        {

        }

        private void buttonDESshowkey_Click(object sender, EventArgs e)
        {
            this.labelDESshowkey.Text = textBoxDESkey.Text;
            this.labelDESshowkey.Visible = true;
        }

        private void buttonDESE_Click(object sender, EventArgs e)
        {
            this.richTextBoxDESE.Text = DES.DESEncrypt(richTextBoxDESstr.Text, textBoxDESkey.Text);

        }

        private void buttonDESD_Click(object sender, EventArgs e)
        {
            this.richTextBoxDESD.Text = DES.DESDecrypt(richTextBoxDESE.Text, textBoxDESkey.Text);

        }
    }
}
