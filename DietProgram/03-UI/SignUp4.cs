using _01_Entity.Concrete;
using _04_BLL.Rules;
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
    public partial class SignUp4 : Form
    {
        RulesOfUser rulesOfUser;

        public SignUp4()
        {
            InitializeComponent();
            rulesOfUser = new RulesOfUser();
        }

        User user;
        bool check;


        private void btnSİGNuP_Click(object sender, EventArgs e)
        {

            try
            {
                user = new User();
                {
                    user.FirstName = txtFirstName.Text.Trim();
                    user.LastName = txtLastName.Text.Trim();
                    user.Email = txtEmail.Text.Trim();
                    if (txtPassword.Text.Trim() == txtPasswordCheck.Text.Trim())
                    {
                        user.Password = txtPassword.Text.Trim();
                    }
                    else
                    {
                        user.Password = "";
                        MessageBox.Show("Passwords do not match, please check passwords!!");
                        txtPassword.Text = "";
                        txtPasswordCheck.Text = "";
                    }
                    user.BirthDate = dtpBirthDate.Value;
                    user.Gender = rbMale.Checked ? rbMale.Text.Trim() : rbFemale.Text.Trim();
                    user.Height = Convert.ToDecimal(txtHeight.Text);
                    user.Weight = Convert.ToDecimal(txtWeight.Text);
                };

                check = rulesOfUser.InsertUser(user);

                MessageBox.Show(check ? "The user has been successfully registered." : "Failed operation. The user could not be registered!!");
            }
            //Errors can be detailed.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (check)
            {
                this.Close();
            }

        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword1.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                chbShowPassword1.Text = "Hide Password";
            }
            else if (chbShowPassword1.CheckState == CheckState.Unchecked)
            {
                txtPassword.UseSystemPasswordChar = true;
                chbShowPassword1.Text = "Show Password";
            }
        }

        private void chbShowPassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword2.CheckState == CheckState.Checked)
            {
                txtPasswordCheck.UseSystemPasswordChar = false;
                chbShowPassword2.Text = "Hide Password";
            }
            else if (chbShowPassword2.CheckState == CheckState.Unchecked)
            {
                txtPasswordCheck.UseSystemPasswordChar = true;
                chbShowPassword2.Text = "Show Password";
            }
        }
    }
}
