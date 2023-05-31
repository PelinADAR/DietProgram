namespace _03_UI
{
    partial class Login2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login2));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.chbShowPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblEmail.Image = ((System.Drawing.Image)(resources.GetObject("lblEmail.Image")));
            this.lblEmail.Location = new System.Drawing.Point(18, 214);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 21);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblPassword.Image = ((System.Drawing.Image)(resources.GetObject("lblPassword.Image")));
            this.lblPassword.Location = new System.Drawing.Point(18, 260);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 21);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtEmail.Location = new System.Drawing.Point(125, 212);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(326, 29);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtPassword.Location = new System.Drawing.Point(125, 258);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(326, 29);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.LemonChiffon;
            this.BtnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.BackgroundImage")));
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.BtnLogin.FlatAppearance.BorderSize = 5;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLogin.ForeColor = System.Drawing.Color.LemonChiffon;
            this.BtnLogin.Location = new System.Drawing.Point(18, 361);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(433, 62);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "LOG IN";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // chbShowPassword
            // 
            this.chbShowPassword.AutoSize = true;
            this.chbShowPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chbShowPassword.BackgroundImage")));
            this.chbShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbShowPassword.ForeColor = System.Drawing.Color.LemonChiffon;
            this.chbShowPassword.Location = new System.Drawing.Point(125, 307);
            this.chbShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbShowPassword.Name = "chbShowPassword";
            this.chbShowPassword.Size = new System.Drawing.Size(112, 19);
            this.chbShowPassword.TabIndex = 2;
            this.chbShowPassword.Text = "Show Password";
            this.chbShowPassword.UseVisualStyleBackColor = true;
            this.chbShowPassword.CheckedChanged += new System.EventHandler(this.chbShowPassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(24, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Not a member yet?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
            this.linkLabel1.LinkColor = System.Drawing.Color.LemonChiffon;
            this.linkLabel1.Location = new System.Drawing.Point(260, 624);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(191, 21);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click Here For Sign Up...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSignup_LinkClicked);
            // 
            // Login2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 669);
            this.Controls.Add(this.chbShowPassword);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FİTOLOGY LOG IN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button BtnLogin;
        private CheckBox chbShowPassword;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}