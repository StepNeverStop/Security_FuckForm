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
    public partial class FormCredential : Form
    {
        public FormCredential()
        {
            InitializeComponent();
        }

        private void comboBoxCredential_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.comboBoxCredential.SelectedIndex)
            {
                case 0:
                    this.richTextBoxCredential.Text = Credential.Version;
                    break;
                case 1:
                    this.richTextBoxCredential.Text = Credential.Num;
                    break;
                case 2:
                    this.richTextBoxCredential.Text = Credential.signmethod;
                    break;
                case 3:
                    this.richTextBoxCredential.Text = Credential.org;
                    break;
                case 4:
                    this.richTextBoxCredential.Text = Credential.timenow.ToShortDateString();
                    break;
                case 5:
                    this.richTextBoxCredential.Text = Credential.timeto.ToShortDateString();
                    break;
                case 6:
                    this.richTextBoxCredential.Text = Credential.user;
                    break;
                case 7:
                    this.richTextBoxCredential.Text = Credential.publickey;
                    break;
                case 8:
                    this.richTextBoxCredential.Text = Credential.casign;
                    break;
                default:break;
            }
        }
    }
}
