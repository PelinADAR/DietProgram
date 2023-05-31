namespace _03_UI
{
    partial class MainMenu3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu3));
            this.btnReports = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblHello = new System.Windows.Forms.Label();
            this.lblCalory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBreakfast = new System.Windows.Forms.Button();
            this.btnDinner = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnSnack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHelloName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnReports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReports.BackgroundImage")));
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.btnReports.FlatAppearance.BorderSize = 5;
            this.btnReports.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReports.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnReports.Location = new System.Drawing.Point(39, 586);
            this.btnReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(402, 62);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.LemonChiffon;
            this.dtpDate.Location = new System.Drawing.Point(132, 127);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(219, 23);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblHello
            // 
            this.lblHello.BackColor = System.Drawing.Color.Black;
            this.lblHello.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHello.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblHello.Image = ((System.Drawing.Image)(resources.GetObject("lblHello.Image")));
            this.lblHello.Location = new System.Drawing.Point(87, 91);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(0, 21);
            this.lblHello.TabIndex = 4;
            this.lblHello.Text = "000";
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHello.Click += new System.EventHandler(this.lblHello_Click);
            // 
            // lblCalory
            // 
            this.lblCalory.AutoSize = true;
            this.lblCalory.BackColor = System.Drawing.Color.Transparent;
            this.lblCalory.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalory.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblCalory.Location = new System.Drawing.Point(265, 152);
            this.lblCalory.Name = "lblCalory";
            this.lblCalory.Size = new System.Drawing.Size(63, 28);
            this.lblCalory.TabIndex = 4;
            this.lblCalory.Text = "Calory";
            this.lblCalory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCalory.Click += new System.EventHandler(this.lblCalory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(132, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Calory :";
            // 
            // btnBreakfast
            // 
            this.btnBreakfast.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnBreakfast.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.btnBreakfast.FlatAppearance.BorderSize = 5;
            this.btnBreakfast.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBreakfast.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBreakfast.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBreakfast.Location = new System.Drawing.Point(13, 35);
            this.btnBreakfast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBreakfast.Name = "btnBreakfast";
            this.btnBreakfast.Size = new System.Drawing.Size(284, 62);
            this.btnBreakfast.TabIndex = 2;
            this.btnBreakfast.Text = "Breakfast";
            this.btnBreakfast.UseVisualStyleBackColor = false;
            this.btnBreakfast.Click += new System.EventHandler(this.btnBreakfast_Click);
            // 
            // btnDinner
            // 
            this.btnDinner.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnDinner.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.btnDinner.FlatAppearance.BorderSize = 5;
            this.btnDinner.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDinner.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDinner.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDinner.Location = new System.Drawing.Point(12, 207);
            this.btnDinner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(284, 62);
            this.btnDinner.TabIndex = 2;
            this.btnDinner.Text = "Dinner";
            this.btnDinner.UseVisualStyleBackColor = false;
            this.btnDinner.Click += new System.EventHandler(this.btnDinner_Click);
            // 
            // btnLunch
            // 
            this.btnLunch.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLunch.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.btnLunch.FlatAppearance.BorderSize = 5;
            this.btnLunch.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLunch.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLunch.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLunch.Location = new System.Drawing.Point(13, 123);
            this.btnLunch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(284, 62);
            this.btnLunch.TabIndex = 2;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = false;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // btnSnack
            // 
            this.btnSnack.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSnack.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.btnSnack.FlatAppearance.BorderSize = 5;
            this.btnSnack.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSnack.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSnack.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSnack.Location = new System.Drawing.Point(13, 295);
            this.btnSnack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSnack.Name = "btnSnack";
            this.btnSnack.Size = new System.Drawing.Size(284, 62);
            this.btnSnack.TabIndex = 2;
            this.btnSnack.Text = "Snack";
            this.btnSnack.UseVisualStyleBackColor = false;
            this.btnSnack.Click += new System.EventHandler(this.btnSnack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(302, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(302, 207);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(302, 123);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(302, 295);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(84, 73);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnSnack);
            this.groupBox1.Controls.Add(this.btnLunch);
            this.groupBox1.Controls.Add(this.btnDinner);
            this.groupBox1.Controls.Add(this.btnBreakfast);
            this.groupBox1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Location = new System.Drawing.Point(39, 175);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(402, 387);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meal Types";
            // 
            // lblHelloName
            // 
            this.lblHelloName.AutoSize = true;
            this.lblHelloName.BackColor = System.Drawing.Color.Transparent;
            this.lblHelloName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHelloName.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblHelloName.Location = new System.Drawing.Point(132, 91);
            this.lblHelloName.Name = "lblHelloName";
            this.lblHelloName.Size = new System.Drawing.Size(67, 28);
            this.lblHelloName.TabIndex = 6;
            this.lblHelloName.Text = "Hello!!!";
            // 
            // MainMenu3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 669);
            this.Controls.Add(this.lblHelloName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCalory);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReports);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USER PAGE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu3_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnReports;
        private DateTimePicker dtpDate;
        private Label lblHello;
        private Label lblCalory;
        private Label label1;
        private Button btnBreakfast;
        private Button btnDinner;
        private Button btnLunch;
        private Button btnSnack;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private GroupBox groupBox1;
        private Label lblHelloName;
    }
}