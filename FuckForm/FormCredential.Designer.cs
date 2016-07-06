namespace FuckForm
{
    partial class FormCredential
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
            this.comboBoxCredential = new System.Windows.Forms.ComboBox();
            this.richTextBoxCredential = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBoxCredential
            // 
            this.comboBoxCredential.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxCredential.FormattingEnabled = true;
            this.comboBoxCredential.Items.AddRange(new object[] {
            "版本",
            "序列号",
            "签名算法",
            "颁证机构",
            "有效期从",
            "到",
            "使用者",
            "公钥",
            "CA签名"});
            this.comboBoxCredential.Location = new System.Drawing.Point(79, 58);
            this.comboBoxCredential.Name = "comboBoxCredential";
            this.comboBoxCredential.Size = new System.Drawing.Size(257, 150);
            this.comboBoxCredential.TabIndex = 0;
            this.comboBoxCredential.SelectedIndexChanged += new System.EventHandler(this.comboBoxCredential_SelectedIndexChanged);
            // 
            // richTextBoxCredential
            // 
            this.richTextBoxCredential.Location = new System.Drawing.Point(79, 214);
            this.richTextBoxCredential.Name = "richTextBoxCredential";
            this.richTextBoxCredential.Size = new System.Drawing.Size(257, 201);
            this.richTextBoxCredential.TabIndex = 1;
            this.richTextBoxCredential.Text = "";
            // 
            // FormCredential
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 498);
            this.Controls.Add(this.richTextBoxCredential);
            this.Controls.Add(this.comboBoxCredential);
            this.Name = "FormCredential";
            this.Text = "X.509 Virtual";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCredential;
        private System.Windows.Forms.RichTextBox richTextBoxCredential;
    }
}