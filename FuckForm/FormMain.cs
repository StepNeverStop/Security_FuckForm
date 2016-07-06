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
    public partial class FormMain : Form
    {
        public void ShutDownAllChildForms()
        {
            Form[] frmList = this.MdiChildren;
            foreach (Form frm in frmList)
            {
                frm.Close();
            }
        }
        public FormMain()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.menuStrip1.Visible = false;
            this.comboBoxLoginV.SelectedIndex = 0;
        }

       

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool flag, flagUser, flagPwd;
            flagUser = UserVerify.user.Equals(textBoxUsername.Text.ToString());
            switch (comboBoxLoginV.SelectedItem.ToString())
            {
                case "MD5":
                    flagPwd = UserVerify.md5Pwd.Equals(MD5.MD5E(textBoxPassword.Text));
                    if (!flagUser)
                    {
                        label7.Text = "用户名不存在!";
                        label7.Visible = true;
                    }
                    else if (!flagPwd)
                    {
                        label7.Text = "密码错误!";
                        label7.Visible = true;
                    }
                    flag = flagUser && flagPwd;

                    break;
                case "SHA":
                    flagPwd = UserVerify.shaPwd.Equals(SHA1.Hash_SHA_1(textBoxPassword.Text));
                    if (!flagUser)
                    {
                        label7.Text = "用户名不存在!";
                        label7.Visible = true;
                    }
                    else if (!flagPwd)
                    {
                        label7.Text = "密码错误!";
                        label7.Visible = true;
                    }
                    flag = flagUser && flagPwd;
                    break;
                default:
                    flag = false;
                    break;
            }
            if (flag)
            {
                this.panelMain.Visible = false;
                this.menuStrip1.Visible = true;
            }
        }

        private void 对称加密ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void dESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShutDownAllChildForms();
            FormDES fdes = new FormDES();
            fdes.MdiParent = this;
            fdes.Location = new Point(0, 0);
            fdes.Show();
            
        }
        private void aESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShutDownAllChildForms();
            FormAES faes = new FormAES();
            faes.Location = new Point(0, 0);

            faes.Show();
            faes.MdiParent = this;
        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShutDownAllChildForms();

            FormRSA frsa = new FormRSA();
            frsa.Location = new Point(0, 0);

            frsa.Show();
            frsa.MdiParent = this;
        }

        private void dHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShutDownAllChildForms();

            FormDH fdh = new FormDH();
            fdh.Location = new Point(0, 0);

            fdh.Show();
            fdh.MdiParent = this;
        }

        private void mD5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShutDownAllChildForms();

            FormMD5 fmd5 = new FormMD5();
            fmd5.Location = new Point(0, 0);

            fmd5.Show();
            fmd5.MdiParent = this;
        }

        private void sHAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShutDownAllChildForms();

            FormSHA fsha = new FormSHA();
            fsha.Location = new Point(0, 0);

            fsha.Show();
            fsha.MdiParent = this;
        }

        private void rSAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShutDownAllChildForms();

            FormSIGN fsign = new FormSIGN();
            fsign.Location = new Point(0, 0);

            fsign.Show();
            fsign.MdiParent = this;
        }

        private void sIGN2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShutDownAllChildForms();

            FormSIGN2 fsign2 = new FormSIGN2();
            fsign2.Location = new Point(0, 0);

            fsign2.Show();
            fsign2.MdiParent = this;
        }
    }
}
