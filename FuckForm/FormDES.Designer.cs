namespace FuckForm
{
    partial class FormDES
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
            this.textBoxDESkey = new System.Windows.Forms.TextBox();
            this.labelDESshowkey = new System.Windows.Forms.Label();
            this.buttonDESshowkey = new System.Windows.Forms.Button();
            this.labelDESkey = new System.Windows.Forms.Label();
            this.buttonDESD = new System.Windows.Forms.Button();
            this.buttonDESE = new System.Windows.Forms.Button();
            this.richTextBoxDESD = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDESE = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDESstr = new System.Windows.Forms.RichTextBox();
            this.labelDESD = new System.Windows.Forms.Label();
            this.labelDESE = new System.Windows.Forms.Label();
            this.labelDESStr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDESkey
            // 
            this.textBoxDESkey.Location = new System.Drawing.Point(486, 137);
            this.textBoxDESkey.MaxLength = 8;
            this.textBoxDESkey.Name = "textBoxDESkey";
            this.textBoxDESkey.PasswordChar = '*';
            this.textBoxDESkey.Size = new System.Drawing.Size(156, 21);
            this.textBoxDESkey.TabIndex = 39;
            // 
            // labelDESshowkey
            // 
            this.labelDESshowkey.AutoSize = true;
            this.labelDESshowkey.Font = new System.Drawing.Font("宋体", 12F);
            this.labelDESshowkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDESshowkey.Location = new System.Drawing.Point(506, 226);
            this.labelDESshowkey.Name = "labelDESshowkey";
            this.labelDESshowkey.Size = new System.Drawing.Size(0, 16);
            this.labelDESshowkey.TabIndex = 38;
            // 
            // buttonDESshowkey
            // 
            this.buttonDESshowkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDESshowkey.Location = new System.Drawing.Point(526, 194);
            this.buttonDESshowkey.Name = "buttonDESshowkey";
            this.buttonDESshowkey.Size = new System.Drawing.Size(75, 23);
            this.buttonDESshowkey.TabIndex = 37;
            this.buttonDESshowkey.Text = "显示密钥";
            this.buttonDESshowkey.UseVisualStyleBackColor = true;
            this.buttonDESshowkey.Click += new System.EventHandler(this.buttonDESshowkey_Click);
            // 
            // labelDESkey
            // 
            this.labelDESkey.AutoSize = true;
            this.labelDESkey.Font = new System.Drawing.Font("宋体", 12F);
            this.labelDESkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDESkey.Location = new System.Drawing.Point(488, 102);
            this.labelDESkey.Name = "labelDESkey";
            this.labelDESkey.Size = new System.Drawing.Size(80, 16);
            this.labelDESkey.TabIndex = 36;
            this.labelDESkey.Text = "八位密钥:";
            // 
            // buttonDESD
            // 
            this.buttonDESD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDESD.Location = new System.Drawing.Point(567, 280);
            this.buttonDESD.Name = "buttonDESD";
            this.buttonDESD.Size = new System.Drawing.Size(77, 66);
            this.buttonDESD.TabIndex = 35;
            this.buttonDESD.Text = "解密";
            this.buttonDESD.UseVisualStyleBackColor = true;
            this.buttonDESD.Click += new System.EventHandler(this.buttonDESD_Click);
            // 
            // buttonDESE
            // 
            this.buttonDESE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDESE.Location = new System.Drawing.Point(466, 280);
            this.buttonDESE.Name = "buttonDESE";
            this.buttonDESE.Size = new System.Drawing.Size(77, 66);
            this.buttonDESE.TabIndex = 34;
            this.buttonDESE.Text = "加密";
            this.buttonDESE.UseVisualStyleBackColor = true;
            this.buttonDESE.Click += new System.EventHandler(this.buttonDESE_Click);
            // 
            // richTextBoxDESD
            // 
            this.richTextBoxDESD.Font = new System.Drawing.Font("宋体", 14F);
            this.richTextBoxDESD.Location = new System.Drawing.Point(155, 270);
            this.richTextBoxDESD.Name = "richTextBoxDESD";
            this.richTextBoxDESD.Size = new System.Drawing.Size(296, 76);
            this.richTextBoxDESD.TabIndex = 33;
            this.richTextBoxDESD.Text = "";
            // 
            // richTextBoxDESE
            // 
            this.richTextBoxDESE.Font = new System.Drawing.Font("宋体", 14F);
            this.richTextBoxDESE.Location = new System.Drawing.Point(155, 181);
            this.richTextBoxDESE.Name = "richTextBoxDESE";
            this.richTextBoxDESE.Size = new System.Drawing.Size(296, 76);
            this.richTextBoxDESE.TabIndex = 32;
            this.richTextBoxDESE.Text = "";
            // 
            // richTextBoxDESstr
            // 
            this.richTextBoxDESstr.Font = new System.Drawing.Font("宋体", 14F);
            this.richTextBoxDESstr.Location = new System.Drawing.Point(155, 99);
            this.richTextBoxDESstr.Name = "richTextBoxDESstr";
            this.richTextBoxDESstr.Size = new System.Drawing.Size(296, 76);
            this.richTextBoxDESstr.TabIndex = 31;
            this.richTextBoxDESstr.Text = "DES";
            // 
            // labelDESD
            // 
            this.labelDESD.AutoSize = true;
            this.labelDESD.Font = new System.Drawing.Font("宋体", 14F);
            this.labelDESD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDESD.Location = new System.Drawing.Point(85, 273);
            this.labelDESD.Name = "labelDESD";
            this.labelDESD.Size = new System.Drawing.Size(66, 19);
            this.labelDESD.TabIndex = 30;
            this.labelDESD.Text = "解密：";
            // 
            // labelDESE
            // 
            this.labelDESE.AutoSize = true;
            this.labelDESE.Font = new System.Drawing.Font("宋体", 14F);
            this.labelDESE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDESE.Location = new System.Drawing.Point(76, 185);
            this.labelDESE.Name = "labelDESE";
            this.labelDESE.Size = new System.Drawing.Size(85, 19);
            this.labelDESE.TabIndex = 29;
            this.labelDESE.Text = "加密后：";
            // 
            // labelDESStr
            // 
            this.labelDESStr.AutoSize = true;
            this.labelDESStr.Font = new System.Drawing.Font("宋体", 14F);
            this.labelDESStr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDESStr.Location = new System.Drawing.Point(85, 99);
            this.labelDESStr.Name = "labelDESStr";
            this.labelDESStr.Size = new System.Drawing.Size(66, 19);
            this.labelDESStr.TabIndex = 28;
            this.labelDESStr.Text = "文本：";
            // 
            // FormDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(720, 444);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxDESkey);
            this.Controls.Add(this.labelDESshowkey);
            this.Controls.Add(this.buttonDESshowkey);
            this.Controls.Add(this.labelDESkey);
            this.Controls.Add(this.buttonDESD);
            this.Controls.Add(this.buttonDESE);
            this.Controls.Add(this.richTextBoxDESD);
            this.Controls.Add(this.richTextBoxDESE);
            this.Controls.Add(this.richTextBoxDESstr);
            this.Controls.Add(this.labelDESD);
            this.Controls.Add(this.labelDESE);
            this.Controls.Add(this.labelDESStr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormDES";
            this.Load += new System.EventHandler(this.FormDES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDESkey;
        private System.Windows.Forms.Label labelDESshowkey;
        private System.Windows.Forms.Button buttonDESshowkey;
        private System.Windows.Forms.Label labelDESkey;
        private System.Windows.Forms.Button buttonDESD;
        private System.Windows.Forms.Button buttonDESE;
        private System.Windows.Forms.RichTextBox richTextBoxDESD;
        private System.Windows.Forms.RichTextBox richTextBoxDESE;
        private System.Windows.Forms.RichTextBox richTextBoxDESstr;
        private System.Windows.Forms.Label labelDESD;
        private System.Windows.Forms.Label labelDESE;
        private System.Windows.Forms.Label labelDESStr;
    }
}