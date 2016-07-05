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
    public partial class FormDH : Form
    {
        public FormDH()
        {
            InitializeComponent();
        }

        private void buttonDHAlice_Click(object sender, EventArgs e)
        {
            string[] value = DH.go(this.richTextBoxDHstr.Text);
            this.richTextBoxDHD.Visible = false;
            this.richTextBoxDHE.Text = value[0];
            this.richTextBoxDHD.Text = value[1];
        }

        private void buttonDHBob_Click(object sender, EventArgs e)
        {
            this.richTextBoxDHD.Visible = true;
        }
    }
}
