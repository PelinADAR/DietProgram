using System;
using _01_Entity.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity.Abstract;

namespace _01_Entity.Concrete
{
    public class SelectedFoodTransfer : IEntity
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public double Amount { get; set; }
        public double Calory { get; set; }
        public int MealId { get; set; }
        public int UserId { get; set; }
        public DateTime DailyCalory { get; set; }

    }
}
