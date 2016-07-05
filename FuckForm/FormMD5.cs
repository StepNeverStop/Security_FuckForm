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
    public partial class FormMD5 : Form
    {
        public FormMD5()
        {
            InitializeComponent();
        }

        private void comboBoxMD51_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMD51.Text.ToString())
            {
                case "Password":
                    labelMD5username.Visible = false;
                    textBoxMD5username.Visible = false;
                    labelMD5password.Visible = true;
                    textBoxMD5password.Visible = true;
                    labelMD5openfile.Visible = false;
                    textBoxMD5openfile.Visible = false;
                    buttonMD5openfile.Visible = false;
                    comboBoxMD52.SelectedIndex = 0;
                    break;
                case "Username+Password":
                    labelMD5username.Visible = true;
                    textBoxMD5username.Visible = true;
                    labelMD5password.Visible = true;
                    textBoxMD5password.Visible = true;
                    labelMD5openfile.Visible = false;
                    textBoxMD5openfile.Visible = false;
                    buttonMD5openfile.Visible = false;
                    comboBoxMD52.SelectedIndex = 0;
                    break;
                default:
                    labelMD5username.Visible = false;
                    textBoxMD5username.Visible = false;
                    labelMD5password.Visible = false;
                    textBoxMD5password.Visible = false;
                    labelMD5openfile.Visible = false;
                    textBoxMD5openfile.Visible = false;
                    buttonMD5openfile.Visible = false;
                    break;
            }
        }

        private void comboBoxMD52_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMD52.Text.ToString())
            {
                case "File_MD5":
                    comboBoxMD51.SelectedIndex = -1;
                    labelMD5username.Visible = false;
                    textBoxMD5username.Visible = false;
                    labelMD5password.Visible = false;
                    textBoxMD5password.Visible = false;
                    labelMD5openfile.Visible = true;
                    textBoxMD5openfile.Visible = true;
                    buttonMD5openfile.Visible = true;

                    break;
                default:
                    labelMD5openfile.Visible = false;
                    textBoxMD5openfile.Visible = false;
                    buttonMD5openfile.Visible = false;
                    break;
            }
        }

        private void buttonMD5openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file1 = new OpenFileDialog();
            file1.Filter = "文本文件|*.txt";
            file1.InitialDirectory = @"D://VS编程/InformationadSafety/InformationadSafety/file";
            if (file1.ShowDialog() == DialogResult.OK)
            {
                textBoxMD5openfile.Text = file1.FileName;
            }
        }

        private void buttonMD5justdoit_Click(object sender, EventArgs e)
        {
            switch (comboBoxMD51.Text.ToString())
            {
                case "":
                    switch (comboBoxMD52.Text.ToString())
                    {
                        case "File_MD5":
                            if (string.IsNullOrWhiteSpace(textBoxMD5openfile.Text) || !File.Exists(textBoxMD5openfile.Text))
                            { MessageBox.Show("请输入合法的路径地址!"); return; }
                            richTextBoxMD5result.Text = MD5.FileMD5E(textBoxMD5openfile.Text);
                            break;
                        default:
                            break;
                    }
                    break;
                case "Password":
                    switch (comboBoxMD52.Text.ToString())
                    {
                        case "MD5":
                            richTextBoxMD5result.Text = MD5.MD5E(textBoxMD5password.Text);
                            break;
                        case "MD5_16":
                            richTextBoxMD5result.Text = MD5.Hash_MD5_16(textBoxMD5password.Text);
                            break;
                        case "MD5_32":
                            richTextBoxMD5result.Text = MD5.Hash_MD5_32(textBoxMD5password.Text);

                            break;
                        case "2_MD5_16":
                            richTextBoxMD5result.Text = MD5.Hash_2_MD5_16(textBoxMD5password.Text);

                            break;
                        case "2_MD5_32":
                            richTextBoxMD5result.Text = MD5.Hash_2_MD5_32(textBoxMD5password.Text);

                            break;
                        default:
                            break;
                    }
                    break;
                case "Username+Password":
                    switch (comboBoxMD52.Text.ToString())
                    {
                        case "MD5":
                            richTextBoxMD5result.Text = MD5.MD5E(textBoxMD5username.Text + textBoxMD5password.Text);
                            break;
                        case "MD5_16":
                            richTextBoxMD5result.Text = MD5.Hash_MD5_16(textBoxMD5username.Text + textBoxMD5password.Text);
                            break;
                        case "MD5_32":
                            richTextBoxMD5result.Text = MD5.Hash_MD5_32(textBoxMD5username.Text + textBoxMD5password.Text);

                            break;
                        case "2_MD5_16":
                            richTextBoxMD5result.Text = MD5.Hash_2_MD5_16(textBoxMD5username.Text + textBoxMD5password.Text);

                            break;
                        case "2_MD5_32":
                            richTextBoxMD5result.Text = MD5.Hash_2_MD5_32(textBoxMD5username.Text + textBoxMD5password.Text);

                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void FormMD5_Load(object sender, EventArgs e)
        {
            this.comboBoxMD51.SelectedIndex = 0;
            this.comboBoxMD52.SelectedIndex = 0;
        }
    }
}
