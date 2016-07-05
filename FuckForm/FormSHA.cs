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

namespace FuckForm
{
    public partial class FormSHA : Form
    {
        public FormSHA()
        {
            InitializeComponent();
        }

        private void buttonSHAopenfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file1 = new OpenFileDialog();
            file1.Filter = "文本文件|*.txt";
            file1.InitialDirectory = @"D://VS编程/InformationadSafety/InformationadSafety/file";
            if (file1.ShowDialog() == DialogResult.OK)
            {
                textBoxSHAopenfile.Text = file1.FileName;
            }
        }

        private void buttonSHAresult_Click(object sender, EventArgs e)
        {
            switch (comboBoxSHA1.Text.ToString())
            {
                case "":
                    switch (comboBoxSHA2.Text.ToString())
                    {
                        case "File_SHA":
                            if (string.IsNullOrWhiteSpace(textBoxSHAopenfile.Text) || !File.Exists(textBoxSHAopenfile.Text))
                            { MessageBox.Show("请输入合法的路径地址!"); return; }
                            richTextBoxSHAresult.Text = SHA1.FileSHA(textBoxSHAopenfile.Text);
                            break;
                        default:
                            break;
                    }
                    break;
                case "Password":
                    switch (comboBoxSHA2.Text.ToString())
                    {
                        case "SHA_1":
                            richTextBoxSHAresult.Text = SHA1.Hash_SHA_1(textBoxSHApassword.Text);
                            break;
                        case "SHA_256":
                            richTextBoxSHAresult.Text = SHA1.Hash_SHA_256(textBoxSHApassword.Text);
                            break;
                        case "SHA_384":
                            richTextBoxSHAresult.Text = SHA1.Hash_SHA_384(textBoxSHApassword.Text);

                            break;
                        case "SHA_512":
                            richTextBoxSHAresult.Text = SHA1.Hash_SHA_512(textBoxSHApassword.Text);

                            break;
                        default:
                            break;
                    }
                    break;
                case "Username+Password":
                    switch (comboBoxSHA2.Text.ToString())
                    {
                        case "SHA_1":
                            richTextBoxSHAresult.Text = SHA1.Hash_SHA_1(textBoxSHAusername.Text + textBoxSHApassword.Text);
                            break;
                        case "SHA_256":
                            richTextBoxSHAresult.Text = SHA1.Hash_SHA_256(textBoxSHAusername.Text + textBoxSHApassword.Text);
                            break;
                        case "SHA_384":
                            richTextBoxSHAresult.Text = SHA1.Hash_SHA_384(textBoxSHAusername.Text + textBoxSHApassword.Text);

                            break;
                        case "SHA_512":
                            richTextBoxSHAresult.Text = SHA1.Hash_SHA_512(textBoxSHAusername.Text + textBoxSHApassword.Text);

                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void FormSHA_Load(object sender, EventArgs e)
        {
            this.comboBoxSHA1.SelectedIndex = 0;
            this.comboBoxSHA2.SelectedIndex = 0;
        }
    }
}
