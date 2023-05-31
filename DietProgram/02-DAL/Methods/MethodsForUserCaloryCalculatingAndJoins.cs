using _02_DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DAL.Methods
{
    public class MethodsForUserCaloryCalculatingAndJoins
    {

        ProjectContext context;
        public MethodsForUserCaloryCalculatingAndJoins()
        {
            context = new ProjectContext();
        }


        public double GetByCalory(int userID, DateTime date)
        {
            var userInformations = context.Foods.Join(context.UserMealFoods, food => food.ID, x => x.FoodID, (food, x) => new UserTotalCalory
            { Id = x.UserID, TotalCalory = (x.Portion / food.Portion) * food.Calory, DailyCalory = x.CreatedDate })
                                                        .Where(a => a.Id == userID && (a.DailyCalory) == date).ToList();

            return userInformations.Sum(a => a.TotalCalory); //linq didn't work, nullable. That's why it's used as a list.
        }
    }
}

public class UserTotalCalory
{
    public double TotalCalory { get; set; }
    public int Id { get; set; }
    public DateTime DailyCalory { get; set; }
}


