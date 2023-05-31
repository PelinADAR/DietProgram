namespace _03_UI
{
    partial class Main1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main1));
            this.btnLetsStart = new System.Windows.Forms.Button();
            this.llblSignup = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLetsStart
            // 
            this.btnLetsStart.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLetsStart.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.btnLetsStart.FlatAppearance.BorderSize = 5;
            resources.ApplyResources(this.btnLetsStart, "btnLetsStart");
            this.btnLetsStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLetsStart.Name = "btnLetsStart";
            this.btnLetsStart.UseVisualStyleBackColor = false;
            this.btnLetsStart.Click += new System.EventHandler(this.btnLetsStart_Click);
            // 
            // llblSignup
            // 
            resources.ApplyResources(this.llblSignup, "llblSignup");
            this.llblSignup.LinkColor = System.Drawing.Color.LemonChiffon;
            this.llblSignup.Name = "llblSignup";
            this.llblSignup.TabStop = true;
            this.llblSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSignup_LinkClicked);
            // 
            // Main1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.llblSignup);
            this.Controls.Add(this.btnLetsStart);
            this.DoubleBuffered = true;
            this.Name = "Main1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLetsStart;
        private LinkLabel llblSignup;
    }
}