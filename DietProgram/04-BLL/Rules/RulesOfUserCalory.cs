using _02_DAL.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BLL.Rules
{
    public class RulesOfUserCalory
    {
        MethodsForUserCaloryCalculatingAndJoins methodsForUserCaloryCalculatingAndJoins;
        public RulesOfUserCalory()
        {
            methodsForUserCaloryCalculatingAndJoins = new MethodsForUserCaloryCalculatingAndJoins();
        }

        public double GetByCalory(int userID, DateTime date)
        {
            if (userID == 0)
            {
                throw new Exception("The parameter value is not suitable.");
            }
            return methodsForUserCaloryCalculatingAndJoins.GetByCalory(userID, date);
        }
    }
}
