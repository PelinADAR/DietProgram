using _01_Entity.Concrete;
using _02_DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DAL.Methods
{
    public class MethodsForMealJoins
    {
        ProjectContext context;


        public MethodsForMealJoins()
        {
            context = new ProjectContext();
        }


        public bool Insert(UserMealFood userMealFood)
        {
            var date = userMealFood.CreatedDate.Date;
            var isExist = context.UserMealFoods.Any(x => x.UserID == userMealFood.UserID && x.FoodID == userMealFood.FoodID && x.MealID == userMealFood.MealID &&(x.CreatedDate) == date);

            if (isExist)
            {
                throw new Exception("This product has already been added. If you want to change the amount, please update it.");
            }

            context.UserMealFoods.Add(userMealFood);
            return context.SaveChanges() > 0;
        }


        public bool Update(UserMealFood food, DateTime date)
        {
            UserMealFood updatedPortion = context.UserMealFoods.Where(x => x.UserID == food.UserID && x.MealID == food.MealID && x.FoodID == food.FoodID && (x.CreatedDate) == date).FirstOrDefault();
            updatedPortion.Portion = food.Portion;
            return context.SaveChanges() > 0;
        }


        public bool Delete(UserMealFood food, DateTime date)
        {
            UserMealFood deletedFood = context.UserMealFoods.Where(x => x.UserID == food.UserID && x.MealID == food.MealID && x.FoodID == food.FoodID && (x.CreatedDate) == date).FirstOrDefault();
            context.UserMealFoods.Remove(deletedFood);
            return context.SaveChanges() > 0;
        }


        public List<SelectedFoodTransfer> GetFood(int mealID, int userId, DateTime date)
        {
            var selectedFood = context.Foods.Join(context.UserMealFoods, food => food.ID, x => x.FoodID, (food, x) => new SelectedFoodTransfer
            { MealId = x.MealID, UserId = x.UserID, FoodName = food.Name, Id = x.FoodID, Amount = x.Portion, Calory = x.Portion * food.Calory, DailyCalory = x.CreatedDate })
                                                 .Where(a => a.MealId == mealID && a.UserId == userId && (a.DailyCalory) == date)
                                                 .ToList();
            return selectedFood;
        }


        //All food items in the database printed on the flow panel.
        public List<Food> FoodsList()
        {
            List<Food> foodsList = context.Foods.ToList();
            return foodsList;
        }


        //Filtered foods in the database printed on the flow panel
        public List<Food> FoodsList(string filteredFood)
        {
            List<Food> foodsList = context.Foods.Where(f => f.Name.Contains(filteredFood)).ToList();
            return foodsList;
        }


        public string GetMealName(int mealID)
        {
            return context.Meals.Where(a => a.ID == mealID).Select(a => a.Name).SingleOrDefault();
        }
    }
}
