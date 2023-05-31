using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_UI
{
    public partial class Main1 : Form
    {
        public Main1()
        {
            InitializeComponent();
        }

        private void btnLetsStart_Click(object sender, EventArgs e)
        {
            Login2 login2 = new Login2();
            this.Hide();
            login2.ShowDialog();
        }

        private void llblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info infoForm = new Info();
            this.Hide();
            infoForm.ShowDialog();
        }
    }
}
