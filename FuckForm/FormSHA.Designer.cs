namespace FuckForm
{
    partial class FormSHA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSHAresult = new System.Windows.Forms.Button();
            this.buttonSHAopenfile = new System.Windows.Forms.Button();
            this.comboBoxSHA2 = new System.Windows.Forms.ComboBox();
            this.labelSHATitle = new System.Windows.Forms.Label();
            this.richTextBoxSHAresult = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSHAresult = new System.Windows.Forms.Label();
            this.textBoxSHApassword = new System.Windows.Forms.TextBox();
            this.comboBoxSHA1 = new System.Windows.Forms.ComboBox();
            this.textBoxSHAopenfile = new System.Windows.Forms.TextBox();
            this.labelSHAusername = new System.Windows.Forms.Label();
            this.textBoxSHAusername = new System.Windows.Forms.TextBox();
            this.labelSHAopenfile = new System.Windows.Forms.Label();
            this.labelSHApassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSHAresult
            // 
            this.buttonSHAresult.Font = new System.Drawing.Font("宋体", 20F);
            this.buttonSHAresult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSHAresult.Location = new System.Drawing.Point(511, 250);
            this.buttonSHAresult.Name = "buttonSHAresult";
            this.buttonSHAresult.Size = new System.Drawing.Size(115, 103);
            this.buttonSHAresult.TabIndex = 41;
            this.buttonSHAresult.Text = "Go";
            this.buttonSHAresult.UseVisualStyleBackColor = true;
            this.buttonSHAresult.Click += new System.EventHandler(this.buttonSHAresult_Click);
            // 
            // buttonSHAopenfile
            // 
            this.buttonSHAopenfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSHAopenfile.Location = new System.Drawing.Point(492, 198);
            this.buttonSHAopenfile.Name = "buttonSHAopenfile";
            this.buttonSHAopenfile.Size = new System.Drawing.Size(33, 23);
            this.buttonSHAopenfile.TabIndex = 29;
            this.buttonSHAopenfile.Text = "...";
            this.buttonSHAopenfile.UseVisualStyleBackColor = true;
            this.buttonSHAopenfile.Visible = false;
            this.buttonSHAopenfile.Click += new System.EventHandler(this.buttonSHAopenfile_Click);
            // 
            // comboBoxSHA2
            // 
            this.comboBoxSHA2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSHA2.FormattingEnabled = true;
            this.comboBoxSHA2.Items.AddRange(new object[] {
            "SHA_1",
            "SHA_256",
            "SHA_384",
            "SHA_512",
            "File_SHA"});
            this.comboBoxSHA2.Location = new System.Drawing.Point(358, 146);
            this.comboBoxSHA2.Name = "comboBoxSHA2";
            this.comboBoxSHA2.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSHA2.TabIndex = 32;
            // 
            // labelSHATitle
            // 
            this.labelSHATitle.AutoSize = true;
            this.labelSHATitle.Font = new System.Drawing.Font("宋体", 20F);
            this.labelSHATitle.ForeColor = System.Drawing.Color.Red;
            this.labelSHATitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSHATitle.Location = new System.Drawing.Point(318, 91);
            this.labelSHATitle.Name = "labelSHATitle";
            this.labelSHATitle.Size = new System.Drawing.Size(54, 27);
            this.labelSHATitle.TabIndex = 28;
            this.labelSHATitle.Text = "SHA";
            // 
            // richTextBoxSHAresult
            // 
            this.richTextBoxSHAresult.Font = new System.Drawing.Font("宋体", 12F);
            this.richTextBoxSHAresult.Location = new System.Drawing.Point(218, 253);
            this.richTextBoxSHAresult.Name = "richTextBoxSHAresult";
            this.richTextBoxSHAresult.Size = new System.Drawing.Size(268, 98);
            this.richTextBoxSHAresult.TabIndex = 40;
            this.richTextBoxSHAresult.Text = "在此显示消息摘要";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(94, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "消息摘要方式：";
            // 
            // labelSHAresult
            // 
            this.labelSHAresult.AutoSize = true;
            this.labelSHAresult.Font = new System.Drawing.Font("宋体", 12F);
            this.labelSHAresult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSHAresult.Location = new System.Drawing.Point(126, 253);
            this.labelSHAresult.Name = "labelSHAresult";
            this.labelSHAresult.Size = new System.Drawing.Size(88, 16);
            this.labelSHAresult.TabIndex = 36;
            this.labelSHAresult.Text = "消息摘要：";
            // 
            // textBoxSHApassword
            // 
            this.textBoxSHApassword.Location = new System.Drawing.Point(220, 219);
            this.textBoxSHApassword.Name = "textBoxSHApassword";
            this.textBoxSHApassword.Size = new System.Drawing.Size(266, 21);
            this.textBoxSHApassword.TabIndex = 39;
            this.textBoxSHApassword.Visible = false;
            // 
            // comboBoxSHA1
            // 
            this.comboBoxSHA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSHA1.FormattingEnabled = true;
            this.comboBoxSHA1.Items.AddRange(new object[] {
            "Password",
            "Username+Password"});
            this.comboBoxSHA1.Location = new System.Drawing.Point(220, 146);
            this.comboBoxSHA1.Name = "comboBoxSHA1";
            this.comboBoxSHA1.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSHA1.TabIndex = 31;
            // 
            // textBoxSHAopenfile
            // 
            this.textBoxSHAopenfile.Location = new System.Drawing.Point(220, 205);
            this.textBoxSHAopenfile.Name = "textBoxSHAopenfile";
            this.textBoxSHAopenfile.Size = new System.Drawing.Size(266, 21);
            this.textBoxSHAopenfile.TabIndex = 38;
            this.textBoxSHAopenfile.Visible = false;
            // 
            // labelSHAusername
            // 
            this.labelSHAusername.AutoSize = true;
            this.labelSHAusername.Font = new System.Drawing.Font("宋体", 12F);
            this.labelSHAusername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSHAusername.Location = new System.Drawing.Point(142, 186);
            this.labelSHAusername.Name = "labelSHAusername";
            this.labelSHAusername.Size = new System.Drawing.Size(72, 16);
            this.labelSHAusername.TabIndex = 33;
            this.labelSHAusername.Text = "用户名：";
            this.labelSHAusername.Visible = false;
            // 
            // textBoxSHAusername
            // 
            this.textBoxSHAusername.Location = new System.Drawing.Point(220, 184);
            this.textBoxSHAusername.Name = "textBoxSHAusername";
            this.textBoxSHAusername.Size = new System.Drawing.Size(266, 21);
            this.textBoxSHAusername.TabIndex = 37;
            this.textBoxSHAusername.Visible = false;
            // 
            // labelSHAopenfile
            // 
            this.labelSHAopenfile.AutoSize = true;
            this.labelSHAopenfile.Font = new System.Drawing.Font("宋体", 12F);
            this.labelSHAopenfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSHAopenfile.Location = new System.Drawing.Point(158, 202);
            this.labelSHAopenfile.Name = "labelSHAopenfile";
            this.labelSHAopenfile.Size = new System.Drawing.Size(56, 16);
            this.labelSHAopenfile.TabIndex = 34;
            this.labelSHAopenfile.Text = "文件：";
            this.labelSHAopenfile.Visible = false;
            // 
            // labelSHApassword
            // 
            this.labelSHApassword.AutoSize = true;
            this.labelSHApassword.Font = new System.Drawing.Font("宋体", 12F);
            this.labelSHApassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSHApassword.Location = new System.Drawing.Point(158, 224);
            this.labelSHApassword.Name = "labelSHApassword";
            this.labelSHApassword.Size = new System.Drawing.Size(56, 16);
            this.labelSHApassword.TabIndex = 35;
            this.labelSHApassword.Text = "口令：";
            this.labelSHApassword.Visible = false;
            // 
            // FormSHA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(720, 444);
            this.Controls.Add(this.buttonSHAresult);
            this.Controls.Add(this.buttonSHAopenfile);
            this.Controls.Add(this.comboBoxSHA2);
            this.Controls.Add(this.labelSHATitle);
            this.Controls.Add(this.richTextBoxSHAresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSHAresult);
            this.Controls.Add(this.textBoxSHApassword);
            this.Controls.Add(this.comboBoxSHA1);
            this.Controls.Add(this.textBoxSHAopenfile);
            this.Controls.Add(this.labelSHAusername);
            this.Controls.Add(this.textBoxSHAusername);
            this.Controls.Add(this.labelSHAopenfile);
            this.Controls.Add(this.labelSHApassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSHA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormSHA";
            this.Load += new System.EventHandler(this.FormSHA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSHAresult;
        private System.Windows.Forms.Button buttonSHAopenfile;
        private System.Windows.Forms.ComboBox comboBoxSHA2;
        private System.Windows.Forms.Label labelSHATitle;
        private System.Windows.Forms.RichTextBox richTextBoxSHAresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSHAresult;
        private System.Windows.Forms.TextBox textBoxSHApassword;
        private System.Windows.Forms.ComboBox comboBoxSHA1;
        private System.Windows.Forms.TextBox textBoxSHAopenfile;
        private System.Windows.Forms.Label labelSHAusername;
        private System.Windows.Forms.TextBox textBoxSHAusername;
        private System.Windows.Forms.Label labelSHAopenfile;
        private System.Windows.Forms.Label labelSHApassword;
    }
}