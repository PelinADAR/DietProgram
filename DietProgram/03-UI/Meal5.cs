using _01_Entity.Concrete;
using _02_DAL.Context;
using _04_BLL.Rules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace _03_UI
{
    public partial class Meal5 : Form
    {
        DateTime selectedDate;
        RulesOfMeal rulesOfMeal;
        public Meal5(User user, int mealId, DateTime selectedDate)
        {
            InitializeComponent();
            this.user = user;
            this.mealId = mealId;
            this.selectedDate = selectedDate;
            rulesOfMeal = new RulesOfMeal();
        }

        User user;
        int mealId;
        double total = 0;

        private void btnGeri_Click(object sender, EventArgs e)
        {
            SignUp4 signUp4 = new SignUp4();
            this.Hide();
            signUp4.Show();
            this.Close();
        }

        private void Meal5_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            //MealName getiriyor.
            string mealName = rulesOfMeal.GetMealName(mealId);
            grpMyMeal.Text = mealName;

            FillListView();

            //lblTotalCalory.Text = rulesOfMeal.GetMealName(mealId) + " " + "Total Calory";

            List<Food> foods = rulesOfMeal.FoodsList();
            foreach (Food item in foods)
            {
                AddFoodsControls(item);
            }

        }

        private void FillListView()
        {
            ListViewItem lvi;
            List<SelectedFoodTransfer> addedFoods = rulesOfMeal.GetFood(mealId, user.ID, selectedDate);
            total = 0;
            foreach (SelectedFoodTransfer item in addedFoods)
            {
                lvi = new ListViewItem();
                lvi.Text = item.FoodName;
                lvi.Tag = item.Id;
                lvi.SubItems.Add(item.Calory.ToString());
                lvi.SubItems.Add(item.Amount.ToString());
                lvwFoodsOfMeal.Items.Add(lvi);
                total += item.Calory;
            }

            lblCaloryValue.Text = total.ToString();
        }
        private void AddFoodsControls(Food item)
        {
            Panel pnlFrame = new Panel();
            pnlFrame.BackColor = Color.Transparent;
            pnlFrame.Width = 400;

            Label lblFoodName = new Label();
            lblFoodName.BackColor = Color.Transparent;
            lblFoodName.ForeColor = Color.DarkGreen;
            lblFoodName.Font = new Font("Segoe Print", 10);
            lblFoodName.Width = 150;
            lblFoodName.Text = item.Name;
            lblFoodName.Tag = $"lblFoodName_{item.ID}";
            lblFoodName.Location = new Point(90, 20);

            Button addButton = new Button();
            addButton.BackColor = Color.DarkGreen;
            addButton.Width = 80;
            addButton.Height = 35;
            addButton.Tag = $"{item.ID}";
            addButton.Text = "ADD";
            addButton.Font = new Font("Segoe Print", 12, FontStyle.Bold);
            addButton.TextAlign = ContentAlignment.MiddleCenter;
            addButton.Location = new Point(300, 30);

            Label lblAmount = new Label();
            lblAmount.BackColor = Color.LemonChiffon;
            lblAmount.Text = "Amount :";
            lblAmount.ForeColor = Color.Black;
            lblAmount.Font = new Font("Segoe Print", 8);
            lblAmount.Width = 60;
            lblAmount.Height = 20;
            lblAmount.Tag = $"lblAmount_{item.ID}";
            lblAmount.Location = new Point(90, 45); //???

            TextBox txtAmount = new TextBox();
            txtAmount.BackColor = Color.LemonChiffon;
            txtAmount.Tag = $"txtAmount_{item.ID}";
            txtAmount.Location = new Point(165, 40);//

            addButton.Click += (sender, e) => { AddClickedButton(sender, e, txtAmount); };

            pnlFrame.Controls.Add(lblFoodName);
            pnlFrame.Controls.Add(addButton);
            pnlFrame.Controls.Add(lblAmount);
            pnlFrame.Controls.Add(txtAmount);
            flpFood.Controls.Add(pnlFrame);
        }


        Button clicked;
        private void AddClickedButton(object sender, EventArgs e, TextBox txtUpdateAmount)
        {
            try
            {
                clicked = sender as Button;
                bool check = rulesOfMeal.Insert(new UserMealFood
                {
                    FoodID = Convert.ToInt32(clicked.Tag),
                    MealID = mealId,
                    UserID = user.ID,
                    CreatedDate = selectedDate,
                    Portion = Convert.ToDouble(txtUpdateAmount.Text.ToString().Replace('.', ',').Trim())
                });
                MessageBox.Show(check ? "Successfully Added!" : "Unsuccessfull Record!");
                lvwFoodsOfMeal.Items.Clear();

                FillListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtUpdateAmount.Clear();
            }
        }

        int foodId;
        private void lvwFoodsOfMeal_MouseClick(object sender, MouseEventArgs e)
        {
            foodId = Convert.ToInt32(lvwFoodsOfMeal.SelectedItems[0].Tag);
            if (lvwFoodsOfMeal.SelectedItems.Count == 1)
            {
                btnDelete.Enabled = true;
            }
            if (lvwFoodsOfMeal.SelectedItems.Count == 1 && txtUpdateAmount.Text != string.Empty)
            {
                btnUpdate.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = rulesOfMeal.Delete(new UserMealFood
                {
                    FoodID = Convert.ToInt32(foodId),
                    MealID = mealId,
                    UserID = user.ID
                }, selectedDate);
                MessageBox.Show(check ? "The relevant meal was removed from the meal." : "Failed operation. The relevant food could not be removed from the meal!!");
                lvwFoodsOfMeal.Items.Clear();
                FillListView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnDelete.Enabled = false;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = rulesOfMeal.Update(new UserMealFood
                {
                    FoodID = Convert.ToInt32(foodId),
                    MealID = mealId,
                    UserID = user.ID,
                    Portion = Convert.ToDouble(txtUpdateAmount.Text.ToString().Replace('.', ',').Trim())
                }, selectedDate);
                if (lvwFoodsOfMeal.SelectedItems.Count > -1 && txtUpdateAmount.Text != null)
                {
                    btnUpdate.Enabled = true;
                }
                MessageBox.Show(check ? "The relevant food amount in the meal has been updated." : "Failed operation. The corresponding amount of food in the meal could not be updated!!");

                txtUpdateAmount.Text = "";
                lvwFoodsOfMeal.Items.Clear();
                FillListView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnUpdate.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            flpFood.Controls.Clear();
            string searchFood = txtSearch.Text;
            List<Food> foods = rulesOfMeal.FoodsList(searchFood);

            foreach (Food item in foods)
            {
                AddFoodsControls(item);
            }
        }
    }
}
