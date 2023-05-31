using System;
using _01_Entity.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity.Abstract;

namespace _01_Entity.Concrete
{
    public class User : IEntity
    {
        public User()
        {
            UserMealFoods = new List<UserMealFood>();
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }

        public virtual ICollection<UserMealFood> UserMealFoods { get; set; }
    }
}