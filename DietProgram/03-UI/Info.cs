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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main1 main1 = new Main1();
            main1.ShowDialog();
        }
    }
}
