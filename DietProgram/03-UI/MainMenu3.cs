using _01_Entity.Concrete;
using _01_Entity.Enum;
using _04_BLL.Rules;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = _01_Entity.Concrete.User;

namespace _03_UI
{
    public partial class MainMenu3 : Form
    {
        User user;
        RulesOfUserCalory rulesOfUserCalory;
        DateTime selectedDate;

        public MainMenu3(User user)
        {
            InitializeComponent();
            this.user = user;
            rulesOfUserCalory = new RulesOfUserCalory();
        }

        private void MainMenu3_Load(object sender, EventArgs e)
        {
            lblHelloName.Text = ("HELLO" + " " + user.FirstName + " " + user.LastName + "!!").ToUpper();
            selectedDate = dtpDate.Value.Date;
            lblCalory.Text = rulesOfUserCalory.GetByCalory(user.ID, selectedDate).ToString() + " " + "kcal";
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            int mealId = (int)MealType.Breakfast;
            Meal5 meal = new Meal5(user, mealId, selectedDate);
            this.Hide();
            meal.ShowDialog();
            this.Show();

            lblCalory.Text = rulesOfUserCalory.GetByCalory(user.ID, selectedDate).ToString() + " " + "kcal";
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            int mealId = (int)MealType.Lunch;
            Meal5 meal = new Meal5(user, mealId, selectedDate);
            this.Hide();
            meal.ShowDialog();
            this.Show();

            lblCalory.Text = rulesOfUserCalory.GetByCalory(user.ID, selectedDate).ToString() + " " + "kcal";
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            int mealId = (int)MealType.Dinner;
            Meal5 meal = new Meal5(user, mealId, selectedDate);
            this.Hide();
            meal.ShowDialog();
            this.Show();

            lblCalory.Text = rulesOfUserCalory.GetByCalory(user.ID, selectedDate).ToString() + " " + "kcal";
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            int mealId = (int)MealType.Snack;
            Meal5 meal = new Meal5(user, mealId, selectedDate);
            this.Hide();
            meal.ShowDialog();
            this.Show();
            lblCalory.Text = rulesOfUserCalory.GetByCalory(user.ID, selectedDate).ToString() + " " + "kcal";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            UserMealReports6 reports = new UserMealReports6(user);
            this.Hide();
            reports.ShowDialog();
            this.Show();
        }

        private void lblCalory_Click(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = dtpDate.Value.Date;
            lblCalory.Text = rulesOfUserCalory.GetByCalory(user.ID, selectedDate).ToString() + " " + "kcal";
        }

        private void lblHello_Click(object sender, EventArgs e)
        {

        }
        private void MainMenu3_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult vote = MessageBox.Show("Are you sure you want to exit the application?", "Exit Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vote == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (vote == DialogResult.No)
            { }
        }
    }
}
