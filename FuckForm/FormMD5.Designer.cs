namespace FuckForm
{
    partial class FormMD5
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
            this.labelMD5Title = new System.Windows.Forms.Label();
            this.buttonMD5justdoit = new System.Windows.Forms.Button();
            this.buttonMD5openfile = new System.Windows.Forms.Button();
            this.comboBoxMD52 = new System.Windows.Forms.ComboBox();
            this.textBoxMD5openfile = new System.Windows.Forms.TextBox();
            this.labelMD5openfile = new System.Windows.Forms.Label();
            this.labelMD5result = new System.Windows.Forms.Label();
            this.richTextBoxMD5result = new System.Windows.Forms.RichTextBox();
            this.textBoxMD5password = new System.Windows.Forms.TextBox();
            this.labelMD5password = new System.Windows.Forms.Label();
            this.labelMD5username = new System.Windows.Forms.Label();
            this.textBoxMD5username = new System.Windows.Forms.TextBox();
            this.comboBoxMD51 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMD5Title
            // 
            this.labelMD5Title.AutoSize = true;
            this.labelMD5Title.Font = new System.Drawing.Font("宋体", 20F);
            this.labelMD5Title.ForeColor = System.Drawing.Color.Red;
            this.labelMD5Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMD5Title.Location = new System.Drawing.Point(317, 93);
            this.labelMD5Title.Name = "labelMD5Title";
            this.labelMD5Title.Size = new System.Drawing.Size(54, 27);
            this.labelMD5Title.TabIndex = 29;
            this.labelMD5Title.Text = "MD5";
            // 
            // buttonMD5justdoit
            // 
            this.buttonMD5justdoit.Font = new System.Drawing.Font("Consolas", 16F);
            this.buttonMD5justdoit.ForeColor = System.Drawing.Color.Red;
            this.buttonMD5justdoit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMD5justdoit.Location = new System.Drawing.Point(536, 257);
            this.buttonMD5justdoit.Name = "buttonMD5justdoit";
            this.buttonMD5justdoit.Size = new System.Drawing.Size(94, 94);
            this.buttonMD5justdoit.TabIndex = 28;
            this.buttonMD5justdoit.Text = "Let Do It !";
            this.buttonMD5justdoit.UseVisualStyleBackColor = true;
            this.buttonMD5justdoit.Click += new System.EventHandler(this.buttonMD5justdoit_Click);
            // 
            // buttonMD5openfile
            // 
            this.buttonMD5openfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMD5openfile.Location = new System.Drawing.Point(470, 202);
            this.buttonMD5openfile.Name = "buttonMD5openfile";
            this.buttonMD5openfile.Size = new System.Drawing.Size(36, 23);
            this.buttonMD5openfile.TabIndex = 27;
            this.buttonMD5openfile.Text = "...";
            this.buttonMD5openfile.UseVisualStyleBackColor = true;
            this.buttonMD5openfile.Visible = false;
            this.buttonMD5openfile.Click += new System.EventHandler(this.buttonMD5openfile_Click);
            // 
            // comboBoxMD52
            // 
            this.comboBoxMD52.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMD52.FormattingEnabled = true;
            this.comboBoxMD52.Items.AddRange(new object[] {
            "MD5",
            "MD5_16",
            "MD5_32",
            "2_MD5_16",
            "2_MD5_32",
            "File_MD5"});
            this.comboBoxMD52.Location = new System.Drawing.Point(351, 147);
            this.comboBoxMD52.Name = "comboBoxMD52";
            this.comboBoxMD52.Size = new System.Drawing.Size(121, 20);
            this.comboBoxMD52.TabIndex = 18;
            this.comboBoxMD52.SelectedIndexChanged += new System.EventHandler(this.comboBoxMD52_SelectedIndexChanged);
            // 
            // textBoxMD5openfile
            // 
            this.textBoxMD5openfile.Location = new System.Drawing.Point(213, 202);
            this.textBoxMD5openfile.Name = "textBoxMD5openfile";
            this.textBoxMD5openfile.Size = new System.Drawing.Size(251, 21);
            this.textBoxMD5openfile.TabIndex = 26;
            this.textBoxMD5openfile.Visible = false;
            // 
            // labelMD5openfile
            // 
            this.labelMD5openfile.AutoSize = true;
            this.labelMD5openfile.Font = new System.Drawing.Font("宋体", 12F);
            this.labelMD5openfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMD5openfile.Location = new System.Drawing.Point(136, 201);
            this.labelMD5openfile.Name = "labelMD5openfile";
            this.labelMD5openfile.Size = new System.Drawing.Size(56, 16);
            this.labelMD5openfile.TabIndex = 25;
            this.labelMD5openfile.Text = "文件：";
            this.labelMD5openfile.Visible = false;
            // 
            // labelMD5result
            // 
            this.labelMD5result.AutoSize = true;
            this.labelMD5result.Font = new System.Drawing.Font("宋体", 12F);
            this.labelMD5result.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMD5result.Location = new System.Drawing.Point(119, 259);
            this.labelMD5result.Name = "labelMD5result";
            this.labelMD5result.Size = new System.Drawing.Size(88, 16);
            this.labelMD5result.TabIndex = 24;
            this.labelMD5result.Text = "消息摘要：";
            // 
            // richTextBoxMD5result
            // 
            this.richTextBoxMD5result.Font = new System.Drawing.Font("宋体", 12F);
            this.richTextBoxMD5result.Location = new System.Drawing.Point(213, 255);
            this.richTextBoxMD5result.Name = "richTextBoxMD5result";
            this.richTextBoxMD5result.Size = new System.Drawing.Size(251, 96);
            this.richTextBoxMD5result.TabIndex = 23;
            this.richTextBoxMD5result.Text = "在此显示摘要";
            // 
            // textBoxMD5password
            // 
            this.textBoxMD5password.Location = new System.Drawing.Point(213, 212);
            this.textBoxMD5password.Name = "textBoxMD5password";
            this.textBoxMD5password.PasswordChar = '*';
            this.textBoxMD5password.Size = new System.Drawing.Size(251, 21);
            this.textBoxMD5password.TabIndex = 22;
            this.textBoxMD5password.Visible = false;
            // 
            // labelMD5password
            // 
            this.labelMD5password.AutoSize = true;
            this.labelMD5password.Font = new System.Drawing.Font("宋体", 12F);
            this.labelMD5password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMD5password.Location = new System.Drawing.Point(135, 214);
            this.labelMD5password.Name = "labelMD5password";
            this.labelMD5password.Size = new System.Drawing.Size(56, 16);
            this.labelMD5password.TabIndex = 21;
            this.labelMD5password.Text = "口令：";
            this.labelMD5password.Visible = false;
            // 
            // labelMD5username
            // 
            this.labelMD5username.AutoSize = true;
            this.labelMD5username.Font = new System.Drawing.Font("宋体", 12F);
            this.labelMD5username.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMD5username.Location = new System.Drawing.Point(119, 185);
            this.labelMD5username.Name = "labelMD5username";
            this.labelMD5username.Size = new System.Drawing.Size(72, 16);
            this.labelMD5username.TabIndex = 20;
            this.labelMD5username.Text = "用户名：";
            this.labelMD5username.Visible = false;
            // 
            // textBoxMD5username
            // 
            this.textBoxMD5username.Location = new System.Drawing.Point(213, 185);
            this.textBoxMD5username.Name = "textBoxMD5username";
            this.textBoxMD5username.Size = new System.Drawing.Size(251, 21);
            this.textBoxMD5username.TabIndex = 19;
            this.textBoxMD5username.Visible = false;
            // 
            // comboBoxMD51
            // 
            this.comboBoxMD51.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMD51.FormattingEnabled = true;
            this.comboBoxMD51.Items.AddRange(new object[] {
            "Password",
            "Username+Password"});
            this.comboBoxMD51.Location = new System.Drawing.Point(213, 146);
            this.comboBoxMD51.Name = "comboBoxMD51";
            this.comboBoxMD51.Size = new System.Drawing.Size(121, 20);
            this.comboBoxMD51.TabIndex = 17;
            this.comboBoxMD51.SelectedIndexChanged += new System.EventHandler(this.comboBoxMD51_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(90, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "消息摘要方式：";
            // 
            // FormMD5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(720, 444);
            this.Controls.Add(this.labelMD5Title);
            this.Controls.Add(this.buttonMD5justdoit);
            this.Controls.Add(this.buttonMD5openfile);
            this.Controls.Add(this.comboBoxMD52);
            this.Controls.Add(this.textBoxMD5openfile);
            this.Controls.Add(this.labelMD5openfile);
            this.Controls.Add(this.labelMD5result);
            this.Controls.Add(this.richTextBoxMD5result);
            this.Controls.Add(this.textBoxMD5password);
            this.Controls.Add(this.labelMD5password);
            this.Controls.Add(this.labelMD5username);
            this.Controls.Add(this.textBoxMD5username);
            this.Controls.Add(this.comboBoxMD51);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMD5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormMD5";
            this.Load += new System.EventHandler(this.FormMD5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMD5Title;
        private System.Windows.Forms.Button buttonMD5justdoit;
        private System.Windows.Forms.Button buttonMD5openfile;
        private System.Windows.Forms.ComboBox comboBoxMD52;
        private System.Windows.Forms.TextBox textBoxMD5openfile;
        private System.Windows.Forms.Label labelMD5openfile;
        private System.Windows.Forms.Label labelMD5result;
        private System.Windows.Forms.RichTextBox richTextBoxMD5result;
        private System.Windows.Forms.TextBox textBoxMD5password;
        private System.Windows.Forms.Label labelMD5password;
        private System.Windows.Forms.Label labelMD5username;
        private System.Windows.Forms.TextBox textBoxMD5username;
        private System.Windows.Forms.ComboBox comboBoxMD51;
        private System.Windows.Forms.Label label3;
    }
}