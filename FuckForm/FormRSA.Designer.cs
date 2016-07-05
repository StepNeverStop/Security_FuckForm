namespace FuckForm
{
    partial class FormRSA
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
            this.richTextBoxRSAshowpbk = new System.Windows.Forms.RichTextBox();
            this.richTextBoxRSAshowpvk = new System.Windows.Forms.RichTextBox();
            this.buttonRSApkeyE = new System.Windows.Forms.Button();
            this.buttonRSApkeyD = new System.Windows.Forms.Button();
            this.buttonRSAshowpvk = new System.Windows.Forms.Button();
            this.buttonRSACreateKeys = new System.Windows.Forms.Button();
            this.richTextBoxRSApkeyD = new System.Windows.Forms.RichTextBox();
            this.richTextBoxRSApkeyE = new System.Windows.Forms.RichTextBox();
            this.richTextBoxRSAstr = new System.Windows.Forms.RichTextBox();
            this.labelRSApkeyD = new System.Windows.Forms.Label();
            this.labelRSApkeyE = new System.Windows.Forms.Label();
            this.labelRSAstr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxRSAshowpbk
            // 
            this.richTextBoxRSAshowpbk.Location = new System.Drawing.Point(481, 132);
            this.richTextBoxRSAshowpbk.Name = "richTextBoxRSAshowpbk";
            this.richTextBoxRSAshowpbk.Size = new System.Drawing.Size(175, 51);
            this.richTextBoxRSAshowpbk.TabIndex = 24;
            this.richTextBoxRSAshowpbk.Text = "";
            this.richTextBoxRSAshowpbk.Visible = false;
            // 
            // richTextBoxRSAshowpvk
            // 
            this.richTextBoxRSAshowpvk.Location = new System.Drawing.Point(481, 219);
            this.richTextBoxRSAshowpvk.Name = "richTextBoxRSAshowpvk";
            this.richTextBoxRSAshowpvk.Size = new System.Drawing.Size(175, 51);
            this.richTextBoxRSAshowpvk.TabIndex = 23;
            this.richTextBoxRSAshowpvk.Text = "";
            this.richTextBoxRSAshowpvk.Visible = false;
            // 
            // buttonRSApkeyE
            // 
            this.buttonRSApkeyE.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonRSApkeyE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRSApkeyE.Location = new System.Drawing.Point(481, 276);
            this.buttonRSApkeyE.Name = "buttonRSApkeyE";
            this.buttonRSApkeyE.Size = new System.Drawing.Size(75, 72);
            this.buttonRSApkeyE.TabIndex = 21;
            this.buttonRSApkeyE.Text = "公钥加密";
            this.buttonRSApkeyE.UseVisualStyleBackColor = true;
            this.buttonRSApkeyE.Click += new System.EventHandler(this.buttonRSApkeyE_Click);
            // 
            // buttonRSApkeyD
            // 
            this.buttonRSApkeyD.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonRSApkeyD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRSApkeyD.Location = new System.Drawing.Point(578, 277);
            this.buttonRSApkeyD.Name = "buttonRSApkeyD";
            this.buttonRSApkeyD.Size = new System.Drawing.Size(75, 70);
            this.buttonRSApkeyD.TabIndex = 22;
            this.buttonRSApkeyD.Text = "私钥解密";
            this.buttonRSApkeyD.UseVisualStyleBackColor = true;
            this.buttonRSApkeyD.Click += new System.EventHandler(this.buttonRSApkeyD_Click);
            // 
            // buttonRSAshowpvk
            // 
            this.buttonRSAshowpvk.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonRSAshowpvk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRSAshowpvk.Location = new System.Drawing.Point(510, 189);
            this.buttonRSAshowpvk.Name = "buttonRSAshowpvk";
            this.buttonRSAshowpvk.Size = new System.Drawing.Size(94, 23);
            this.buttonRSAshowpvk.TabIndex = 20;
            this.buttonRSAshowpvk.Text = "显示私钥";
            this.buttonRSAshowpvk.UseVisualStyleBackColor = true;
            this.buttonRSAshowpvk.Visible = false;
            this.buttonRSAshowpvk.Click += new System.EventHandler(this.buttonRSAshowpvk_Click);
            // 
            // buttonRSACreateKeys
            // 
            this.buttonRSACreateKeys.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonRSACreateKeys.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRSACreateKeys.Location = new System.Drawing.Point(510, 97);
            this.buttonRSACreateKeys.Name = "buttonRSACreateKeys";
            this.buttonRSACreateKeys.Size = new System.Drawing.Size(94, 23);
            this.buttonRSACreateKeys.TabIndex = 19;
            this.buttonRSACreateKeys.Text = "生成密钥对";
            this.buttonRSACreateKeys.UseVisualStyleBackColor = true;
            this.buttonRSACreateKeys.Click += new System.EventHandler(this.buttonRSACreateKeys_Click);
            // 
            // richTextBoxRSApkeyD
            // 
            this.richTextBoxRSApkeyD.Location = new System.Drawing.Point(148, 276);
            this.richTextBoxRSApkeyD.Name = "richTextBoxRSApkeyD";
            this.richTextBoxRSApkeyD.Size = new System.Drawing.Size(309, 64);
            this.richTextBoxRSApkeyD.TabIndex = 18;
            this.richTextBoxRSApkeyD.Text = "";
            // 
            // richTextBoxRSApkeyE
            // 
            this.richTextBoxRSApkeyE.Location = new System.Drawing.Point(148, 198);
            this.richTextBoxRSApkeyE.Name = "richTextBoxRSApkeyE";
            this.richTextBoxRSApkeyE.Size = new System.Drawing.Size(309, 64);
            this.richTextBoxRSApkeyE.TabIndex = 17;
            this.richTextBoxRSApkeyE.Text = "";
            // 
            // richTextBoxRSAstr
            // 
            this.richTextBoxRSAstr.Location = new System.Drawing.Point(148, 128);
            this.richTextBoxRSAstr.Name = "richTextBoxRSAstr";
            this.richTextBoxRSAstr.Size = new System.Drawing.Size(309, 64);
            this.richTextBoxRSAstr.TabIndex = 16;
            this.richTextBoxRSAstr.Text = "";
            // 
            // labelRSApkeyD
            // 
            this.labelRSApkeyD.AutoSize = true;
            this.labelRSApkeyD.Font = new System.Drawing.Font("宋体", 12F);
            this.labelRSApkeyD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelRSApkeyD.Location = new System.Drawing.Point(65, 279);
            this.labelRSApkeyD.Name = "labelRSApkeyD";
            this.labelRSApkeyD.Size = new System.Drawing.Size(88, 16);
            this.labelRSApkeyD.TabIndex = 15;
            this.labelRSApkeyD.Text = "私钥解密：";
            // 
            // labelRSApkeyE
            // 
            this.labelRSApkeyE.AutoSize = true;
            this.labelRSApkeyE.Font = new System.Drawing.Font("宋体", 12F);
            this.labelRSApkeyE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelRSApkeyE.Location = new System.Drawing.Point(65, 211);
            this.labelRSApkeyE.Name = "labelRSApkeyE";
            this.labelRSApkeyE.Size = new System.Drawing.Size(88, 16);
            this.labelRSApkeyE.TabIndex = 14;
            this.labelRSApkeyE.Text = "公钥加密：";
            // 
            // labelRSAstr
            // 
            this.labelRSAstr.AutoSize = true;
            this.labelRSAstr.Font = new System.Drawing.Font("宋体", 12F);
            this.labelRSAstr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelRSAstr.Location = new System.Drawing.Point(97, 150);
            this.labelRSAstr.Name = "labelRSAstr";
            this.labelRSAstr.Size = new System.Drawing.Size(56, 16);
            this.labelRSAstr.TabIndex = 13;
            this.labelRSAstr.Text = "文本：";
            // 
            // FormRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(720, 444);
            this.Controls.Add(this.richTextBoxRSAshowpbk);
            this.Controls.Add(this.richTextBoxRSAshowpvk);
            this.Controls.Add(this.buttonRSApkeyE);
            this.Controls.Add(this.buttonRSApkeyD);
            this.Controls.Add(this.buttonRSAshowpvk);
            this.Controls.Add(this.buttonRSACreateKeys);
            this.Controls.Add(this.richTextBoxRSApkeyD);
            this.Controls.Add(this.richTextBoxRSApkeyE);
            this.Controls.Add(this.richTextBoxRSAstr);
            this.Controls.Add(this.labelRSApkeyD);
            this.Controls.Add(this.labelRSApkeyE);
            this.Controls.Add(this.labelRSAstr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRSA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormRSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxRSAshowpbk;
        private System.Windows.Forms.RichTextBox richTextBoxRSAshowpvk;
        private System.Windows.Forms.Button buttonRSApkeyE;
        private System.Windows.Forms.Button buttonRSApkeyD;
        private System.Windows.Forms.Button buttonRSAshowpvk;
        private System.Windows.Forms.Button buttonRSACreateKeys;
        private System.Windows.Forms.RichTextBox richTextBoxRSApkeyD;
        private System.Windows.Forms.RichTextBox richTextBoxRSApkeyE;
        private System.Windows.Forms.RichTextBox richTextBoxRSAstr;
        private System.Windows.Forms.Label labelRSApkeyD;
        private System.Windows.Forms.Label labelRSApkeyE;
        private System.Windows.Forms.Label labelRSAstr;
    }
}