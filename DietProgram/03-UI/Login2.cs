using _01_Entity.Concrete;
using _04_BLL.Rules;
using Microsoft.Win32;
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
    public partial class Login2 : Form
    {
        RulesOfUser rulesOfUser;

        public Login2()
        {
            InitializeComponent();
            rulesOfUser = new RulesOfUser();
        }

        User user;
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            try
            {
                user = rulesOfUser.CheckLogin(email, password);
                if (user != null)
                {
                    MainMenu3 mainMenu3 = new MainMenu3(user);
                    mainMenu3.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid login attempt. Username or password incorrect!!!\r\nIf you are not a member, register.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void lbkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp4 signUp4 = new SignUp4();
            this.Hide();
            signUp4.ShowDialog();
        }



        private void llblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp4 signUp4 = new SignUp4();
            this.Hide();
            signUp4.ShowDialog();
            this.Show();

        }


        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                chbShowPassword.Text = "Hide Password";
            }
            else if (chbShowPassword.CheckState == CheckState.Unchecked)
            {
                txtPassword.UseSystemPasswordChar = true;
                chbShowPassword.Text = "Show Password";
            }
        }

    }
}
