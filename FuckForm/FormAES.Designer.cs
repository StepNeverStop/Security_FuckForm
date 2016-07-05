namespace FuckForm
{
    partial class FormAES
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
            this.textBoxAESkey = new System.Windows.Forms.TextBox();
            this.labelAESshowkey = new System.Windows.Forms.Label();
            this.buttonAESshowkey = new System.Windows.Forms.Button();
            this.labelAESkey = new System.Windows.Forms.Label();
            this.buttonAESD = new System.Windows.Forms.Button();
            this.buttonAESE = new System.Windows.Forms.Button();
            this.richTextBoxAESD = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAESE = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAESstr = new System.Windows.Forms.RichTextBox();
            this.labelAESD = new System.Windows.Forms.Label();
            this.labelAESE = new System.Windows.Forms.Label();
            this.labelAESstr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAESkey
            // 
            this.textBoxAESkey.Location = new System.Drawing.Point(486, 137);
            this.textBoxAESkey.MaxLength = 32;
            this.textBoxAESkey.Name = "textBoxAESkey";
            this.textBoxAESkey.PasswordChar = '*';
            this.textBoxAESkey.Size = new System.Drawing.Size(156, 21);
            this.textBoxAESkey.TabIndex = 24;
            // 
            // labelAESshowkey
            // 
            this.labelAESshowkey.AutoSize = true;
            this.labelAESshowkey.Font = new System.Drawing.Font("宋体", 12F);
            this.labelAESshowkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAESshowkey.Location = new System.Drawing.Point(490, 220);
            this.labelAESshowkey.Name = "labelAESshowkey";
            this.labelAESshowkey.Size = new System.Drawing.Size(0, 16);
            this.labelAESshowkey.TabIndex = 23;
            this.labelAESshowkey.Visible = false;
            // 
            // buttonAESshowkey
            // 
            this.buttonAESshowkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAESshowkey.Location = new System.Drawing.Point(526, 194);
            this.buttonAESshowkey.Name = "buttonAESshowkey";
            this.buttonAESshowkey.Size = new System.Drawing.Size(75, 23);
            this.buttonAESshowkey.TabIndex = 22;
            this.buttonAESshowkey.Text = "显示密钥";
            this.buttonAESshowkey.UseVisualStyleBackColor = true;
            this.buttonAESshowkey.Click += new System.EventHandler(this.buttonAESshowkey_Click);
            // 
            // labelAESkey
            // 
            this.labelAESkey.AutoSize = true;
            this.labelAESkey.Font = new System.Drawing.Font("宋体", 12F);
            this.labelAESkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAESkey.Location = new System.Drawing.Point(488, 102);
            this.labelAESkey.Name = "labelAESkey";
            this.labelAESkey.Size = new System.Drawing.Size(112, 16);
            this.labelAESkey.TabIndex = 21;
            this.labelAESkey.Text = "三十二位密钥:";
            // 
            // buttonAESD
            // 
            this.buttonAESD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAESD.Location = new System.Drawing.Point(567, 280);
            this.buttonAESD.Name = "buttonAESD";
            this.buttonAESD.Size = new System.Drawing.Size(77, 66);
            this.buttonAESD.TabIndex = 20;
            this.buttonAESD.Text = "解密";
            this.buttonAESD.UseVisualStyleBackColor = true;
            this.buttonAESD.Click += new System.EventHandler(this.buttonAESD_Click);
            // 
            // buttonAESE
            // 
            this.buttonAESE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAESE.Location = new System.Drawing.Point(466, 280);
            this.buttonAESE.Name = "buttonAESE";
            this.buttonAESE.Size = new System.Drawing.Size(77, 66);
            this.buttonAESE.TabIndex = 19;
            this.buttonAESE.Text = "加密";
            this.buttonAESE.UseVisualStyleBackColor = true;
            this.buttonAESE.Click += new System.EventHandler(this.buttonAESE_Click);
            // 
            // richTextBoxAESD
            // 
            this.richTextBoxAESD.Font = new System.Drawing.Font("宋体", 14F);
            this.richTextBoxAESD.Location = new System.Drawing.Point(155, 270);
            this.richTextBoxAESD.Name = "richTextBoxAESD";
            this.richTextBoxAESD.Size = new System.Drawing.Size(296, 76);
            this.richTextBoxAESD.TabIndex = 18;
            this.richTextBoxAESD.Text = "";
            // 
            // richTextBoxAESE
            // 
            this.richTextBoxAESE.Font = new System.Drawing.Font("宋体", 14F);
            this.richTextBoxAESE.Location = new System.Drawing.Point(155, 181);
            this.richTextBoxAESE.Name = "richTextBoxAESE";
            this.richTextBoxAESE.Size = new System.Drawing.Size(296, 76);
            this.richTextBoxAESE.TabIndex = 17;
            this.richTextBoxAESE.Text = "";
            // 
            // richTextBoxAESstr
            // 
            this.richTextBoxAESstr.Font = new System.Drawing.Font("宋体", 14F);
            this.richTextBoxAESstr.Location = new System.Drawing.Point(155, 99);
            this.richTextBoxAESstr.Name = "richTextBoxAESstr";
            this.richTextBoxAESstr.Size = new System.Drawing.Size(296, 76);
            this.richTextBoxAESstr.TabIndex = 16;
            this.richTextBoxAESstr.Text = "AES";
            // 
            // labelAESD
            // 
            this.labelAESD.AutoSize = true;
            this.labelAESD.Font = new System.Drawing.Font("宋体", 14F);
            this.labelAESD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAESD.Location = new System.Drawing.Point(85, 273);
            this.labelAESD.Name = "labelAESD";
            this.labelAESD.Size = new System.Drawing.Size(66, 19);
            this.labelAESD.TabIndex = 15;
            this.labelAESD.Text = "解密：";
            // 
            // labelAESE
            // 
            this.labelAESE.AutoSize = true;
            this.labelAESE.Font = new System.Drawing.Font("宋体", 14F);
            this.labelAESE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAESE.Location = new System.Drawing.Point(76, 185);
            this.labelAESE.Name = "labelAESE";
            this.labelAESE.Size = new System.Drawing.Size(85, 19);
            this.labelAESE.TabIndex = 14;
            this.labelAESE.Text = "加密后：";
            // 
            // labelAESstr
            // 
            this.labelAESstr.AutoSize = true;
            this.labelAESstr.Font = new System.Drawing.Font("宋体", 14F);
            this.labelAESstr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAESstr.Location = new System.Drawing.Point(85, 99);
            this.labelAESstr.Name = "labelAESstr";
            this.labelAESstr.Size = new System.Drawing.Size(66, 19);
            this.labelAESstr.TabIndex = 13;
            this.labelAESstr.Text = "文本：";
            // 
            // FormAES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(720, 444);
            this.Controls.Add(this.textBoxAESkey);
            this.Controls.Add(this.labelAESshowkey);
            this.Controls.Add(this.buttonAESshowkey);
            this.Controls.Add(this.labelAESkey);
            this.Controls.Add(this.buttonAESD);
            this.Controls.Add(this.buttonAESE);
            this.Controls.Add(this.richTextBoxAESD);
            this.Controls.Add(this.richTextBoxAESE);
            this.Controls.Add(this.richTextBoxAESstr);
            this.Controls.Add(this.labelAESD);
            this.Controls.Add(this.labelAESE);
            this.Controls.Add(this.labelAESstr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormAES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAESkey;
        private System.Windows.Forms.Label labelAESshowkey;
        private System.Windows.Forms.Button buttonAESshowkey;
        private System.Windows.Forms.Label labelAESkey;
        private System.Windows.Forms.Button buttonAESD;
        private System.Windows.Forms.Button buttonAESE;
        private System.Windows.Forms.RichTextBox richTextBoxAESD;
        private System.Windows.Forms.RichTextBox richTextBoxAESE;
        private System.Windows.Forms.RichTextBox richTextBoxAESstr;
        private System.Windows.Forms.Label labelAESD;
        private System.Windows.Forms.Label labelAESE;
        private System.Windows.Forms.Label labelAESstr;
    }
}