using _01_Entity.Concrete;
using _02_DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DAL.Methods
{
    public class MethodsForUserCheck
    {
        ProjectContext context;
        public MethodsForUserCheck()
        {
            context = new ProjectContext();
        }


        public bool Insert(User user)
        {
            context.Users.Add(user);
            return context.SaveChanges() > 0;
        }


        public User CheckLogin(string email, string password)
        {
            User user = context.Users.Where(a => a.Email == email && a.Password == password).SingleOrDefault();

            return user;
        }


        public bool IsExistEmail(string email)
        {
            return context.Users.Any(a => a.Email == email);
        }
    }

}

