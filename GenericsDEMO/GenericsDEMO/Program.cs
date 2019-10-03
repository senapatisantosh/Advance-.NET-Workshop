using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDEMO
{
    class ProgramDemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================  Custom GENERICS DEMO =======================");
            Student stu = new Student();
            stu.Name = "Santosh";
            stu.RollNo = 120;
            stu.SurName = "Senapati";
            stu.Phone = "7204789018";
            CustomGenerics.print<Student>(stu);
            Employee emp = new Employee();
            emp.Name = "Santosh";
            emp.EmpID = 120;
            Console.WriteLine("================  Custom GENERICS DEMO =======================");

            CustomGenerics.print<Employee>(emp);
            Console.ReadKey();
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public long EmpID { get; set; }
    }
    class Student
    {
        public string Name { get; set; }
        public long RollNo { get; set; }

        public string SurName { get; set; }
        public string Phone { get; set; }
    }
}
