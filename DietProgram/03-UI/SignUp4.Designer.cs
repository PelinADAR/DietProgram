namespace _03_UI
{
    partial class SignUp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp4));
            this.chbShowPassword1 = new System.Windows.Forms.CheckBox();
            this.btnSİGNuP = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblPasswordCheck = new System.Windows.Forms.Label();
            this.txtPasswordCheck = new System.Windows.Forms.TextBox();
            this.chbShowPassword2 = new System.Windows.Forms.CheckBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // chbShowPassword1
            // 
            this.chbShowPassword1.AutoSize = true;
            this.chbShowPassword1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chbShowPassword1.BackgroundImage")));
            this.chbShowPassword1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbShowPassword1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.chbShowPassword1.Location = new System.Drawing.Point(157, 293);
            this.chbShowPassword1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbShowPassword1.Name = "chbShowPassword1";
            this.chbShowPassword1.Size = new System.Drawing.Size(112, 19);
            this.chbShowPassword1.TabIndex = 4;
            this.chbShowPassword1.Text = "Show Password";
            this.chbShowPassword1.UseVisualStyleBackColor = true;
            this.chbShowPassword1.CheckedChanged += new System.EventHandler(this.chbShowPassword_CheckedChanged);
            // 
            // btnSİGNuP
            // 
            this.btnSİGNuP.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSİGNuP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSİGNuP.BackgroundImage")));
            this.btnSİGNuP.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.btnSİGNuP.FlatAppearance.BorderSize = 5;
            this.btnSİGNuP.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSİGNuP.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnSİGNuP.Location = new System.Drawing.Point(46, 567);
            this.btnSİGNuP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSİGNuP.Name = "btnSİGNuP";
            this.btnSİGNuP.Size = new System.Drawing.Size(374, 62);
            this.btnSİGNuP.TabIndex = 12;
            this.btnSİGNuP.Text = "SIGN UP";
            this.btnSİGNuP.UseVisualStyleBackColor = false;
            this.btnSİGNuP.Click += new System.EventHandler(this.btnSİGNuP_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtPassword.Location = new System.Drawing.Point(157, 250);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(263, 29);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtEmail.Location = new System.Drawing.Point(157, 197);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 29);
            this.txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblPassword.Image = ((System.Drawing.Image)(resources.GetObject("lblPassword.Image")));
            this.lblPassword.Location = new System.Drawing.Point(46, 252);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(93, 21);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password*:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblEmail.Image = ((System.Drawing.Image)(resources.GetObject("lblEmail.Image")));
            this.lblEmail.Location = new System.Drawing.Point(46, 199);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 21);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblFirstName.Image = ((System.Drawing.Image)(resources.GetObject("lblFirstName.Image")));
            this.lblFirstName.Location = new System.Drawing.Point(46, 102);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 21);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtFirstName.Location = new System.Drawing.Point(157, 102);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(263, 29);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblLastName.Image = ((System.Drawing.Image)(resources.GetObject("lblLastName.Image")));
            this.lblLastName.Location = new System.Drawing.Point(46, 150);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 21);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtLastName.Location = new System.Drawing.Point(157, 150);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(263, 29);
            this.txtLastName.TabIndex = 1;
            // 
            // lblPasswordCheck
            // 
            this.lblPasswordCheck.AutoSize = true;
            this.lblPasswordCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordCheck.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblPasswordCheck.Image = ((System.Drawing.Image)(resources.GetObject("lblPasswordCheck.Image")));
            this.lblPasswordCheck.Location = new System.Drawing.Point(46, 321);
            this.lblPasswordCheck.Name = "lblPasswordCheck";
            this.lblPasswordCheck.Size = new System.Drawing.Size(93, 21);
            this.lblPasswordCheck.TabIndex = 5;
            this.lblPasswordCheck.Text = "Password*:";
            this.lblPasswordCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPasswordCheck
            // 
            this.txtPasswordCheck.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtPasswordCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordCheck.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtPasswordCheck.Location = new System.Drawing.Point(157, 319);
            this.txtPasswordCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordCheck.Name = "txtPasswordCheck";
            this.txtPasswordCheck.Size = new System.Drawing.Size(263, 29);
            this.txtPasswordCheck.TabIndex = 5;
            this.txtPasswordCheck.UseSystemPasswordChar = true;
            // 
            // chbShowPassword2
            // 
            this.chbShowPassword2.AutoSize = true;
            this.chbShowPassword2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chbShowPassword2.BackgroundImage")));
            this.chbShowPassword2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbShowPassword2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.chbShowPassword2.Location = new System.Drawing.Point(157, 363);
            this.chbShowPassword2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbShowPassword2.Name = "chbShowPassword2";
            this.chbShowPassword2.Size = new System.Drawing.Size(112, 19);
            this.chbShowPassword2.TabIndex = 6;
            this.chbShowPassword2.Text = "Show Password";
            this.chbShowPassword2.UseVisualStyleBackColor = true;
            this.chbShowPassword2.CheckedChanged += new System.EventHandler(this.chbShowPassword2_CheckedChanged);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBirthDate.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblBirthDate.Image = ((System.Drawing.Image)(resources.GetObject("lblBirthDate.Image")));
            this.lblBirthDate.Location = new System.Drawing.Point(46, 389);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(91, 21);
            this.lblBirthDate.TabIndex = 5;
            this.lblBirthDate.Text = "Birth Date:";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(157, 389);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(263, 23);
            this.dtpBirthDate.TabIndex = 7;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblGender.Image = ((System.Drawing.Image)(resources.GetObject("lblGender.Image")));
            this.lblGender.Location = new System.Drawing.Point(46, 427);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(70, 21);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.BackColor = System.Drawing.Color.LemonChiffon;
            this.rbFemale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbFemale.BackgroundImage")));
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbFemale.ForeColor = System.Drawing.Color.LemonChiffon;
            this.rbFemale.Location = new System.Drawing.Point(166, 427);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(83, 25);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = false;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeight.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblHeight.Image = ((System.Drawing.Image)(resources.GetObject("lblHeight.Image")));
            this.lblHeight.Location = new System.Drawing.Point(46, 469);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(66, 21);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Height:";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHeight.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtHeight.Location = new System.Drawing.Point(157, 467);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(263, 29);
            this.txtHeight.TabIndex = 10;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeight.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblWeight.Image = ((System.Drawing.Image)(resources.GetObject("lblWeight.Image")));
            this.lblWeight.Location = new System.Drawing.Point(46, 513);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(70, 21);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Weight:";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWeight.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtWeight.Location = new System.Drawing.Point(157, 511);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(263, 29);
            this.txtWeight.TabIndex = 11;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.Color.LemonChiffon;
            this.rbMale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbMale.BackgroundImage")));
            this.rbMale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbMale.ForeColor = System.Drawing.Color.LemonChiffon;
            this.rbMale.Location = new System.Drawing.Point(279, 427);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 25);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = false;
            // 
            // SignUp4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 669);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.chbShowPassword2);
            this.Controls.Add(this.chbShowPassword1);
            this.Controls.Add(this.btnSİGNuP);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtPasswordCheck);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblPasswordCheck);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignUp4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGN UP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chbShowPassword;
        private Button btnSİGNuP;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblPasswordCheck;
        private TextBox txtPasswordCheck;
        private CheckBox checkBox1;
        private Label lblBirthDate;
        private DateTimePicker dtpBirthDate;
        private Label lblGender;
        private RadioButton rbFemale;
        private Label lblHeight;
        private TextBox txtHeight;
        private Label lblWeight;
        private TextBox txtWeight;
        private RadioButton rbMale;
        private CheckBox chbShowPassword1;
        private CheckBox chbShowPassword2;
    }
}