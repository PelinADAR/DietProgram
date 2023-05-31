using _01_Entity.Concrete;
using _02_DAL.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BLL.Rules
{
    public class RulesOfMeal
    {
        MethodsForMealJoins methodsForMealJoins;
        public RulesOfMeal()
        {
            methodsForMealJoins = new MethodsForMealJoins();
        }

        public bool Insert(UserMealFood userMealFood)
        {
            return methodsForMealJoins.Insert(userMealFood);
        }

        public bool Update(UserMealFood food, DateTime date)
        {
            if (food.FoodID == 0)
            {
                throw new Exception("Please select the product you want to update.");
            }

            return methodsForMealJoins.Update(food, date);

        }

        public bool Delete(UserMealFood food, DateTime date)
        {
            if (food.FoodID == 0)
            {
                throw new Exception("Please select the product you want to delete.");
            }

            return methodsForMealJoins.Delete(food, date);
        }

        public List<SelectedFoodTransfer> GetFood(int mealID, int userID, DateTime date)
        {
            List<SelectedFoodTransfer> selectedFoods = new List<SelectedFoodTransfer>();
            if (mealID > 0)
            {
                selectedFoods = methodsForMealJoins.GetFood(mealID, userID, date);
            }
            return selectedFoods;
        }


        public List<Food> FoodsList()
        {
            return methodsForMealJoins.FoodsList();
        }

        public List<Food> FoodsList(string filteredFood)
        {
            return methodsForMealJoins.FoodsList(filteredFood);
        }


        public string GetMealName(int mealID)
        {
            if (mealID < 1)
            {
                throw new Exception("Parameter value is not suitable!");
            }
            return methodsForMealJoins.GetMealName(mealID);
        }
    }
}
