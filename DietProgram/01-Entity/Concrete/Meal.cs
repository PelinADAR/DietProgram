using System;
using _01_Entity.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity.Abstract;

namespace _01_Entity.Concrete
{
    public class Meal : IEntity
    {
        public Meal()
        {
            UserMealFoods = new List<UserMealFood>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserMealFood> UserMealFoods { get; set; }
    }
}