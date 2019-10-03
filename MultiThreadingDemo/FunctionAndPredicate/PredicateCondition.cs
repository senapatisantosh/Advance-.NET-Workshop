using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionAndPredicate
{
    class PredicateCondition
    {
        public static List<T> filteredEmployeesMethod<T>(List<T> obj,Func<T,bool> func) where T: class
        {
            List<T> filteredEmployees = new List<T>();
            foreach (var item in obj)
            {
                if (func(item))
                {
                    filteredEmployees.Add(item);
                }
            }

            return filteredEmployees;
        }
    }
}
