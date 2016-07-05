namespace FuckForm
{
    partial class FormSIGN
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
            this.richTextBoxSIGNpvk = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSIGNpvkE = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSIGNpbkV = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSIGNMD5 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSIGNstr = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSIGNMD5result = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSIGNpbk = new System.Windows.Forms.RichTextBox();
            this.buttonSIGNMD5V = new System.Windows.Forms.Button();
            this.buttonSIGNMD5 = new System.Windows.Forms.Button();
            this.buttonSIGNpbkV = new System.Windows.Forms.Button();
            this.buttonSIGNpvkE = new System.Windows.Forms.Button();
            this.buttonSIGNshowpvk = new System.Windows.Forms.Button();
            this.buttonSIGNcreatekeys = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxSIGNpvk
            // 
            this.richTextBoxSIGNpvk.Location = new System.Drawing.Point(59, 257);
            this.richTextBoxSIGNpvk.Name = "richTextBoxSIGNpvk";
            this.richTextBoxSIGNpvk.Size = new System.Drawing.Size(100, 99);
            this.richTextBoxSIGNpvk.TabIndex = 13;
            this.richTextBoxSIGNpvk.Text = "";
            this.richTextBoxSIGNpvk.Visible = false;
            // 
            // richTextBoxSIGNpvkE
            // 
            this.richTextBoxSIGNpvkE.Location = new System.Drawing.Point(214, 240);
            this.richTextBoxSIGNpvkE.Name = "richTextBoxSIGNpvkE";
            this.richTextBoxSIGNpvkE.Size = new System.Drawing.Size(298, 38);
            this.richTextBoxSIGNpvkE.TabIndex = 14;
            this.richTextBoxSIGNpvkE.Text = "私钥加密文本";
            // 
            // richTextBoxSIGNpbkV
            // 
            this.richTextBoxSIGNpbkV.Location = new System.Drawing.Point(214, 318);
            this.richTextBoxSIGNpbkV.Name = "richTextBoxSIGNpbkV";
            this.richTextBoxSIGNpbkV.Size = new System.Drawing.Size(298, 38);
            this.richTextBoxSIGNpbkV.TabIndex = 15;
            this.richTextBoxSIGNpbkV.Text = "公钥解密文本";
            // 
            // richTextBoxSIGNMD5
            // 
            this.richTextBoxSIGNMD5.Location = new System.Drawing.Point(218, 162);
            this.richTextBoxSIGNMD5.Name = "richTextBoxSIGNMD5";
            this.richTextBoxSIGNMD5.Size = new System.Drawing.Size(298, 38);
            this.richTextBoxSIGNMD5.TabIndex = 16;
            this.richTextBoxSIGNMD5.Text = "消息摘要";
            // 
            // richTextBoxSIGNstr
            // 
            this.richTextBoxSIGNstr.Location = new System.Drawing.Point(218, 88);
            this.richTextBoxSIGNstr.Name = "richTextBoxSIGNstr";
            this.richTextBoxSIGNstr.Size = new System.Drawing.Size(298, 38);
            this.richTextBoxSIGNstr.TabIndex = 17;
            this.richTextBoxSIGNstr.Text = "文本";
            // 
            // richTextBoxSIGNMD5result
            // 
            this.richTextBoxSIGNMD5result.Location = new System.Drawing.Point(551, 228);
            this.richTextBoxSIGNMD5result.Name = "richTextBoxSIGNMD5result";
            this.richTextBoxSIGNMD5result.Size = new System.Drawing.Size(110, 48);
            this.richTextBoxSIGNMD5result.TabIndex = 18;
            this.richTextBoxSIGNMD5result.Text = "消息摘要与公钥解密文本验证";
            // 
            // richTextBoxSIGNpbk
            // 
            this.richTextBoxSIGNpbk.Location = new System.Drawing.Point(59, 125);
            this.richTextBoxSIGNpbk.Name = "richTextBoxSIGNpbk";
            this.richTextBoxSIGNpbk.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxSIGNpbk.TabIndex = 19;
            this.richTextBoxSIGNpbk.Text = "公钥";
            // 
            // buttonSIGNMD5V
            // 
            this.buttonSIGNMD5V.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSIGNMD5V.Location = new System.Drawing.Point(549, 199);
            this.buttonSIGNMD5V.Name = "buttonSIGNMD5V";
            this.buttonSIGNMD5V.Size = new System.Drawing.Size(108, 23);
            this.buttonSIGNMD5V.TabIndex = 12;
            this.buttonSIGNMD5V.Text = "MD5完整性检验";
            this.buttonSIGNMD5V.UseVisualStyleBackColor = true;
            this.buttonSIGNMD5V.Click += new System.EventHandler(this.buttonSIGNMD5V_Click);
            // 
            // buttonSIGNMD5
            // 
            this.buttonSIGNMD5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSIGNMD5.Location = new System.Drawing.Point(328, 133);
            this.buttonSIGNMD5.Name = "buttonSIGNMD5";
            this.buttonSIGNMD5.Size = new System.Drawing.Size(75, 23);
            this.buttonSIGNMD5.TabIndex = 11;
            this.buttonSIGNMD5.Text = "MD5摘要";
            this.buttonSIGNMD5.UseVisualStyleBackColor = true;
            this.buttonSIGNMD5.Click += new System.EventHandler(this.buttonSIGNMD5_Click);
            // 
            // buttonSIGNpbkV
            // 
            this.buttonSIGNpbkV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSIGNpbkV.Location = new System.Drawing.Point(328, 289);
            this.buttonSIGNpbkV.Name = "buttonSIGNpbkV";
            this.buttonSIGNpbkV.Size = new System.Drawing.Size(75, 23);
            this.buttonSIGNpbkV.TabIndex = 10;
            this.buttonSIGNpbkV.Text = "公钥验证";
            this.buttonSIGNpbkV.UseVisualStyleBackColor = true;
            this.buttonSIGNpbkV.Click += new System.EventHandler(this.buttonSIGNpbkV_Click);
            // 
            // buttonSIGNpvkE
            // 
            this.buttonSIGNpvkE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSIGNpvkE.Location = new System.Drawing.Point(328, 208);
            this.buttonSIGNpvkE.Name = "buttonSIGNpvkE";
            this.buttonSIGNpvkE.Size = new System.Drawing.Size(75, 23);
            this.buttonSIGNpvkE.TabIndex = 9;
            this.buttonSIGNpvkE.Text = "私钥加密";
            this.buttonSIGNpvkE.UseVisualStyleBackColor = true;
            this.buttonSIGNpvkE.Click += new System.EventHandler(this.buttonSIGNpvkE_Click);
            // 
            // buttonSIGNshowpvk
            // 
            this.buttonSIGNshowpvk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSIGNshowpvk.Location = new System.Drawing.Point(74, 228);
            this.buttonSIGNshowpvk.Name = "buttonSIGNshowpvk";
            this.buttonSIGNshowpvk.Size = new System.Drawing.Size(75, 23);
            this.buttonSIGNshowpvk.TabIndex = 8;
            this.buttonSIGNshowpvk.Text = "显示私钥";
            this.buttonSIGNshowpvk.UseVisualStyleBackColor = true;
            this.buttonSIGNshowpvk.Click += new System.EventHandler(this.buttonSIGNshowpvk_Click);
            // 
            // buttonSIGNcreatekeys
            // 
            this.buttonSIGNcreatekeys.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSIGNcreatekeys.Location = new System.Drawing.Point(74, 91);
            this.buttonSIGNcreatekeys.Name = "buttonSIGNcreatekeys";
            this.buttonSIGNcreatekeys.Size = new System.Drawing.Size(75, 23);
            this.buttonSIGNcreatekeys.TabIndex = 7;
            this.buttonSIGNcreatekeys.Text = "生成密钥对";
            this.buttonSIGNcreatekeys.UseVisualStyleBackColor = true;
            this.buttonSIGNcreatekeys.Click += new System.EventHandler(this.buttonSIGNcreatekeys_Click);
            // 
            // FormSIGN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(720, 444);
            this.Controls.Add(this.richTextBoxSIGNpvk);
            this.Controls.Add(this.richTextBoxSIGNpvkE);
            this.Controls.Add(this.richTextBoxSIGNpbkV);
            this.Controls.Add(this.richTextBoxSIGNMD5);
            this.Controls.Add(this.richTextBoxSIGNstr);
            this.Controls.Add(this.richTextBoxSIGNMD5result);
            this.Controls.Add(this.richTextBoxSIGNpbk);
            this.Controls.Add(this.buttonSIGNMD5V);
            this.Controls.Add(this.buttonSIGNMD5);
            this.Controls.Add(this.buttonSIGNpbkV);
            this.Controls.Add(this.buttonSIGNpvkE);
            this.Controls.Add(this.buttonSIGNshowpvk);
            this.Controls.Add(this.buttonSIGNcreatekeys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSIGN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormSign";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSIGNcreatekeys;
        private System.Windows.Forms.Button buttonSIGNshowpvk;
        private System.Windows.Forms.Button buttonSIGNpvkE;
        private System.Windows.Forms.Button buttonSIGNpbkV;
        private System.Windows.Forms.Button buttonSIGNMD5;
        private System.Windows.Forms.Button buttonSIGNMD5V;
        private System.Windows.Forms.RichTextBox richTextBoxSIGNpbk;
        private System.Windows.Forms.RichTextBox richTextBoxSIGNMD5result;
        private System.Windows.Forms.RichTextBox richTextBoxSIGNstr;
        private System.Windows.Forms.RichTextBox richTextBoxSIGNMD5;
        private System.Windows.Forms.RichTextBox richTextBoxSIGNpbkV;
        private System.Windows.Forms.RichTextBox richTextBoxSIGNpvkE;
        private System.Windows.Forms.RichTextBox richTextBoxSIGNpvk;
    }
}