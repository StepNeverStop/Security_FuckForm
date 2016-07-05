namespace FuckForm
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.对称加密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.非对称加密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.散列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数字签名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelLoginV = new System.Windows.Forms.Label();
            this.comboBoxLoginV = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelMainPText = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.对称加密ToolStripMenuItem,
            this.非对称加密ToolStripMenuItem,
            this.散列ToolStripMenuItem,
            this.数字签名ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 对称加密ToolStripMenuItem
            // 
            this.对称加密ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dESToolStripMenuItem,
            this.aESToolStripMenuItem});
            this.对称加密ToolStripMenuItem.Name = "对称加密ToolStripMenuItem";
            this.对称加密ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.对称加密ToolStripMenuItem.Text = "对称加密";
            // 
            // dESToolStripMenuItem
            // 
            this.dESToolStripMenuItem.Name = "dESToolStripMenuItem";
            this.dESToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.dESToolStripMenuItem.Text = "DES";
            this.dESToolStripMenuItem.Click += new System.EventHandler(this.dESToolStripMenuItem_Click);
            // 
            // aESToolStripMenuItem
            // 
            this.aESToolStripMenuItem.Name = "aESToolStripMenuItem";
            this.aESToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.aESToolStripMenuItem.Text = "AES";
            this.aESToolStripMenuItem.Click += new System.EventHandler(this.aESToolStripMenuItem_Click);
            // 
            // 非对称加密ToolStripMenuItem
            // 
            this.非对称加密ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rSAToolStripMenuItem,
            this.dHToolStripMenuItem});
            this.非对称加密ToolStripMenuItem.Name = "非对称加密ToolStripMenuItem";
            this.非对称加密ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.非对称加密ToolStripMenuItem.Text = "非对称加密";
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.rSAToolStripMenuItem.Text = "RSA";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.rSAToolStripMenuItem_Click);
            // 
            // dHToolStripMenuItem
            // 
            this.dHToolStripMenuItem.Name = "dHToolStripMenuItem";
            this.dHToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.dHToolStripMenuItem.Text = "D-H";
            this.dHToolStripMenuItem.Click += new System.EventHandler(this.dHToolStripMenuItem_Click);
            // 
            // 散列ToolStripMenuItem
            // 
            this.散列ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mD5ToolStripMenuItem,
            this.sHAToolStripMenuItem});
            this.散列ToolStripMenuItem.Name = "散列ToolStripMenuItem";
            this.散列ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.散列ToolStripMenuItem.Text = "散列";
            // 
            // mD5ToolStripMenuItem
            // 
            this.mD5ToolStripMenuItem.Name = "mD5ToolStripMenuItem";
            this.mD5ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.mD5ToolStripMenuItem.Text = "MD5";
            this.mD5ToolStripMenuItem.Click += new System.EventHandler(this.mD5ToolStripMenuItem_Click);
            // 
            // sHAToolStripMenuItem
            // 
            this.sHAToolStripMenuItem.Name = "sHAToolStripMenuItem";
            this.sHAToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sHAToolStripMenuItem.Text = "SHA";
            this.sHAToolStripMenuItem.Click += new System.EventHandler(this.sHAToolStripMenuItem_Click);
            // 
            // 数字签名ToolStripMenuItem
            // 
            this.数字签名ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rSAToolStripMenuItem1});
            this.数字签名ToolStripMenuItem.Name = "数字签名ToolStripMenuItem";
            this.数字签名ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数字签名ToolStripMenuItem.Text = "数字签名";
            // 
            // rSAToolStripMenuItem1
            // 
            this.rSAToolStripMenuItem1.Name = "rSAToolStripMenuItem1";
            this.rSAToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.rSAToolStripMenuItem1.Text = "RSA";
            this.rSAToolStripMenuItem1.Click += new System.EventHandler(this.rSAToolStripMenuItem1_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.DarkGray;
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.buttonLogin);
            this.panelMain.Controls.Add(this.labelLoginV);
            this.panelMain.Controls.Add(this.comboBoxLoginV);
            this.panelMain.Controls.Add(this.textBoxPassword);
            this.panelMain.Controls.Add(this.labelPassword);
            this.panelMain.Controls.Add(this.labelUsername);
            this.panelMain.Controls.Add(this.textBoxUsername);
            this.panelMain.Controls.Add(this.labelMainPText);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(793, 444);
            this.panelMain.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(337, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 14);
            this.label7.TabIndex = 8;
            this.label7.Visible = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("宋体", 10.5F);
            this.buttonLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonLogin.Location = new System.Drawing.Point(326, 298);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "登陆";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelLoginV
            // 
            this.labelLoginV.AutoSize = true;
            this.labelLoginV.Font = new System.Drawing.Font("宋体", 10.5F);
            this.labelLoginV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLoginV.Location = new System.Drawing.Point(224, 248);
            this.labelLoginV.Name = "labelLoginV";
            this.labelLoginV.Size = new System.Drawing.Size(77, 14);
            this.labelLoginV.TabIndex = 6;
            this.labelLoginV.Text = "验证方式：";
            // 
            // comboBoxLoginV
            // 
            this.comboBoxLoginV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoginV.FormattingEnabled = true;
            this.comboBoxLoginV.Items.AddRange(new object[] {
            "MD5",
            "SHA"});
            this.comboBoxLoginV.Location = new System.Drawing.Point(307, 247);
            this.comboBoxLoginV.Name = "comboBoxLoginV";
            this.comboBoxLoginV.Size = new System.Drawing.Size(121, 20);
            this.comboBoxLoginV.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(307, 207);
            this.textBoxPassword.MaxLength = 16;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(169, 21);
            this.textBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("宋体", 12F);
            this.labelPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPassword.Location = new System.Drawing.Point(237, 207);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 16);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "口令：";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("宋体", 12F);
            this.labelUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelUsername.Location = new System.Drawing.Point(229, 172);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(72, 16);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "用户名：";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(307, 172);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(169, 21);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelMainPText
            // 
            this.labelMainPText.AutoSize = true;
            this.labelMainPText.Font = new System.Drawing.Font("宋体", 15F);
            this.labelMainPText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMainPText.Location = new System.Drawing.Point(272, 105);
            this.labelMainPText.Name = "labelMainPText";
            this.labelMainPText.Size = new System.Drawing.Size(149, 20);
            this.labelMainPText.TabIndex = 0;
            this.labelMainPText.Text = "信息安全小工具";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 481);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "信息安全小玩意儿";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 对称加密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 非对称加密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 散列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mD5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数字签名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Label labelMainPText;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxLoginV;
        private System.Windows.Forms.Label labelLoginV;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelMain;
    }
}

