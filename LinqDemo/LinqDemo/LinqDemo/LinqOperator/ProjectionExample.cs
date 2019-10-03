using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo.LinqDemo.LinqOperator
{

    class Employee
    {
        public string Name { get; set; }
        public List<string> Addresses { get; set; }
    }
    class ProjectionExample
    {
        public static void GetProjectionExample()
        {
            Employee obj1 = new Employee() { Name = "Santosh", Addresses = new List<string>() { "AddressT1", "AddressP1" } };
            Employee obj2 = new Employee() { Name = "Rajesh", Addresses = new List<string>() { "AddressP3" } };
            Employee obj3 = new Employee() { Name = "Pritam", Addresses = new List<string>() { "AddressT3", "AddressP3" } };
            Employee obj4 = new Employee() { Name = "Abhishek", Addresses = new List<string>() { "AddressT4", "AddressP4" } };
            Employee obj5 = new Employee() { Name = "Arya", Addresses = new List<string>() { "AddressT5" } };
            Employee obj6 = new Employee() { Name = "Prakash", Addresses = new List<string>() { "AddressT6", "AddressP6" } };
            List<Employee> employees = new List<Employee>() {
                obj1,
                obj2,
                obj3,
                obj4,
                obj5,
                obj6
            };

            //Print All THe Address
            var result1 = employees.Select(x => x.Addresses);
            foreach (var item in result1)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }

            var result2 = employees.SelectMany(x => x.Addresses);
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }


        }
    }
}
