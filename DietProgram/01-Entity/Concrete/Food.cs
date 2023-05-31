using System;
using _01_Entity.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity.Abstract;

namespace _01_Entity.Concrete
{
    public class Food : IEntity
    {
        public Food()
        {
            UserMealFoods = new List<UserMealFood>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public double Calory { get; set; }
        public double Portion { get; set; }
        public int FoodCategoryID { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
        public virtual ICollection<UserMealFood> UserMealFoods { get; set; }

    }
}

