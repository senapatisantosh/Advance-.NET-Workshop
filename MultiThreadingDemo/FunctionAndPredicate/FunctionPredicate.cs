using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionAndPredicate
{
    public class Employee
    {
        public int empID { get; set; }
        public string Name { get; set; }

        public int NoOfLeaves { get; set; }

        public bool EmploymentStatus { get; set;  }
    }
    public class FunctionPredicate
    {
        static void Main(string[] args)
        {
            #region Func<>
            //Func<int,int> func = (i) => {
            //                                Console.WriteLine($"Current Value {i}");
            //                                return i + 5;
            //                            };
            ////Func<int, int, int> func = new Func<int, int, int>(addition);
            //Console.WriteLine(func(2)); 
            #endregion

            #region Predicate
            List<Employee> obj = new List<Employee>();
            obj.Add(new Employee
            {
                empID = 1,
                Name = "Santosh",
                NoOfLeaves = 4
            });
            obj.Add(new Employee
            {
                empID = 2,
                Name = "Rajesh",
                NoOfLeaves = 2

            });
            obj.Add(new Employee
            {
                empID = 3,
                Name = "Vikash",
                NoOfLeaves = 0
            });
            obj.Add(new Employee
            {
                empID = 4,
                Name = "Raghav",
                NoOfLeaves = 0,
                EmploymentStatus = true
            });

            List<Employee> filteredEmployees = PredicateCondition.filteredEmployeesMethod(obj,(x)=>x.EmploymentStatus==true && x.NoOfLeaves ==0);
            foreach (var item in filteredEmployees)
            {
                Console.WriteLine($"Employee Name: {item.Name}");
            }

            #endregion


            Console.ReadKey();
        }

    




        //static int addition(int i)
        //{
        //    Console.WriteLine($"Current Value {i}");
        //    return i+5;
        //}
    }
}
