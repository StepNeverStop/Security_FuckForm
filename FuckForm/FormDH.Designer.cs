namespace FuckForm
{
    partial class FormDH
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
            this.labelDHstr = new System.Windows.Forms.Label();
            this.richTextBoxDHD = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDHE = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDHstr = new System.Windows.Forms.RichTextBox();
            this.buttonDHBob = new System.Windows.Forms.Button();
            this.buttonDHAlice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDHstr
            // 
            this.labelDHstr.AutoSize = true;
            this.labelDHstr.Font = new System.Drawing.Font("宋体", 12F);
            this.labelDHstr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDHstr.Location = new System.Drawing.Point(123, 103);
            this.labelDHstr.Name = "labelDHstr";
            this.labelDHstr.Size = new System.Drawing.Size(56, 16);
            this.labelDHstr.TabIndex = 10;
            this.labelDHstr.Text = "文本：";
            // 
            // richTextBoxDHD
            // 
            this.richTextBoxDHD.Font = new System.Drawing.Font("宋体", 12F);
            this.richTextBoxDHD.Location = new System.Drawing.Point(201, 272);
            this.richTextBoxDHD.Name = "richTextBoxDHD";
            this.richTextBoxDHD.Size = new System.Drawing.Size(419, 79);
            this.richTextBoxDHD.TabIndex = 9;
            this.richTextBoxDHD.Text = "";
            this.richTextBoxDHD.Visible = false;
            // 
            // richTextBoxDHE
            // 
            this.richTextBoxDHE.Font = new System.Drawing.Font("宋体", 12F);
            this.richTextBoxDHE.Location = new System.Drawing.Point(201, 182);
            this.richTextBoxDHE.Name = "richTextBoxDHE";
            this.richTextBoxDHE.Size = new System.Drawing.Size(419, 79);
            this.richTextBoxDHE.TabIndex = 8;
            this.richTextBoxDHE.Text = "";
            // 
            // richTextBoxDHstr
            // 
            this.richTextBoxDHstr.Font = new System.Drawing.Font("宋体", 12F);
            this.richTextBoxDHstr.Location = new System.Drawing.Point(201, 93);
            this.richTextBoxDHstr.Name = "richTextBoxDHstr";
            this.richTextBoxDHstr.Size = new System.Drawing.Size(419, 79);
            this.richTextBoxDHstr.TabIndex = 7;
            this.richTextBoxDHstr.Text = "";
            // 
            // buttonDHBob
            // 
            this.buttonDHBob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDHBob.Location = new System.Drawing.Point(101, 278);
            this.buttonDHBob.Name = "buttonDHBob";
            this.buttonDHBob.Size = new System.Drawing.Size(75, 23);
            this.buttonDHBob.TabIndex = 5;
            this.buttonDHBob.Text = "Bob解密";
            this.buttonDHBob.UseVisualStyleBackColor = true;
            // 
            // buttonDHAlice
            // 
            this.buttonDHAlice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDHAlice.Location = new System.Drawing.Point(101, 185);
            this.buttonDHAlice.Name = "buttonDHAlice";
            this.buttonDHAlice.Size = new System.Drawing.Size(75, 23);
            this.buttonDHAlice.TabIndex = 6;
            this.buttonDHAlice.Text = "Alice加密";
            this.buttonDHAlice.UseVisualStyleBackColor = true;
            // 
            // FormDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(720, 444);
            this.Controls.Add(this.labelDHstr);
            this.Controls.Add(this.richTextBoxDHD);
            this.Controls.Add(this.richTextBoxDHE);
            this.Controls.Add(this.richTextBoxDHstr);
            this.Controls.Add(this.buttonDHBob);
            this.Controls.Add(this.buttonDHAlice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormDH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDHAlice;
        private System.Windows.Forms.Button buttonDHBob;
        private System.Windows.Forms.RichTextBox richTextBoxDHstr;
        private System.Windows.Forms.RichTextBox richTextBoxDHE;
        private System.Windows.Forms.RichTextBox richTextBoxDHD;
        private System.Windows.Forms.Label labelDHstr;
    }
}