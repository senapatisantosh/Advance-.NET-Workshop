using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo.LinqDemo
{
    class DeferedAndImmediateExecution
    {
        public static void DeferedExecutionLINQ()
        {
            List<string> EmpolyeeNames = new List<string>()
                                        {
                                            "Santosh",
                                            "Pritam",
                                            "Abhishek",
                                            "Sai Suhas",
                                            "Sri Ram"
                                        };
            var results = from name in EmpolyeeNames
                          where name.Contains(" ") != true
                          select name;

            EmpolyeeNames.Add("Arya");

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

        }
        public static void ImmediateExecutionLINQ()
        {
            List<string> EmpolyeeNames = new List<string>()
                                        {
                                            "Santosh",
                                            "Pritam",
                                            "Abhishek",
                                            "Sai Suhas",
                                            "Sri Ram"
                                        };
            var results = (from name in EmpolyeeNames
                          where name.Contains(" ") != true
                          select name).ToList();

            EmpolyeeNames.Add("Arya");

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
