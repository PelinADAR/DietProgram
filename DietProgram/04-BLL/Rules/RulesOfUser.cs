using _01_Entity.Concrete;
using _02_DAL.Context;
using _02_DAL.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_BLL.Rules
{
    
    public class RulesOfUser
    {
        ProjectContext context;

        MethodsForUserCheck methodsForUserCheck;
        public RulesOfUser()
        {
            context = new ProjectContext();
            methodsForUserCheck = new MethodsForUserCheck();
        }

        public User CheckLogin(string email, string password)
        {
            User user = context.Users.FirstOrDefault(a => a.Email == email && a.Password == password);
            return user;
        }

        public bool InsertUser(User user)
        {
            if (string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName) || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.BirthDate.ToString()))
            {
                throw new Exception("Fill in the user information!!");
            };

            foreach (char item in user.FirstName)
            {
                if (char.IsDigit(item))
                {
                    throw new Exception("Enter only letters for the firstname.");
                }
            }


            foreach (char item in user.LastName)
            {
                if (char.IsDigit(item))
                {
                    throw new Exception("Enter only letters for the lastname.");
                }
            }

            //REGEX METHODS:
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.Match(user.Email).Success)
            {
                throw new Exception("Please enter a valid e-mail address.");
            }

            if (!CheckPassword(user))
            {
                throw new Exception("Password must be a minimum of 8 characters. Password must contain at least 1 uppercase, at least 1 lowercase letter and number.");
            }

            if (user.BirthDate.Date > DateTime.Now.Date)
            {
                throw new Exception("The date of birth cannot be a future date.");
            }

           
            if (methodsForUserCheck.IsExistEmail(user.Email))
            {
                throw new Exception("Failed registration. There is a user registration at this e-mail address!!");
            }

            user.CreatedDate = DateTime.Now;

            return methodsForUserCheck.Insert(user);
        }


        //PASSWORD HASH WILL BE ADDED.
        public bool CheckPassword(User user)
        {
            bool isPasswordLength = false;
            bool isNumber = false;
            bool isCharLower = false;
            bool isCharUpper = false;

            if (user.Password.Length > 6)
            {
                isPasswordLength = true;
            }
            foreach (char item in user.Password)
            {
                if (char.IsUpper(item))
                {
                    isCharUpper = true;
                }
                else if (char.IsLower(item))
                {
                    isCharLower = true;
                }
                else if (char.IsDigit(item))
                {
                    isNumber = true;
                }
            }

            if (!isCharUpper || !isCharLower || !isNumber || !isPasswordLength)
            {
                return false;
            }

            return true;
        }

    }
}
