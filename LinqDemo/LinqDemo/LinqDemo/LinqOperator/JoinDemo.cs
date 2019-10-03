using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo.LinqDemo.LinqOperator
{
    class Student
    {
        public string Name { get; set; }
        public int StudentID { get; set; }
        public int DeptID { get; set; }

    }
    class Department
    {
        public string DepartmentName { get; set; }
        public int DepartmentID { get; set; }
    }
    class JoinDemo
    {
        public static void GetJoinExample()
        {
            //Created THe Mock
            Department dep1 = new Department() { DepartmentID = 1, DepartmentName = "IT" };
            Department dep2 = new Department() { DepartmentID = 2, DepartmentName = "CSE" };
            Department dep3 = new Department() { DepartmentID = 3, DepartmentName = "ECE" };
            Department dep4 = new Department() { DepartmentID = 4, DepartmentName = "MECH" };
            

            Student s1 = new Student() { Name = "Santosh", StudentID = 1, DeptID = 2 };
            Student s2 = new Student() { Name = "Rajesh", StudentID = 2, DeptID = 4 };
            Student s3 = new Student() { Name = "Arya", StudentID = 3, DeptID = 2 };
            Student s4 = new Student() { Name = "Pritam", StudentID = 4, DeptID = 3 };
            Student s5 = new Student() { Name = "Rahul", StudentID = 5, DeptID = 2 };
            Student s6 = new Student() { Name = "Pradosh", StudentID = 6, DeptID = 4 };
            Student s7 = new Student() { Name = "Ranak", StudentID = 7, DeptID = 3 };
            Student s8 = new Student() { Name = "Ranjit", StudentID = 8, DeptID = 1 };
            Student s9 = new Student() { Name = "Yatin", StudentID = 9, DeptID = 4 };
            Student s10 = new Student() { Name = "Milind", StudentID = 10, DeptID = 4 };
            Student s11 = new Student() { Name = "Farhath", StudentID = 11, DeptID = 1 };
            Student s12 = new Student() { Name = "Naveen", StudentID = 12, DeptID = 1 };
            Student s13 = new Student() { Name = "Abhishek", StudentID = 13, DeptID = 1 };
            List<Student> students = new List<Student>()
            {
                s1 ,
                s2 ,
                s3 ,
                s4 ,
                s5 ,
                s6 ,
                s7 ,
                s8 ,
                s9 ,
                s10,
                s11,
                s12,
                s13
            };
            List<Department> departments = new List<Department>()
            {
                dep1,
                dep2,
                dep3,
                dep4
            };

            var results = from d in departments
                          join s in students on
                          d.DepartmentID equals s.DeptID
                          group d.DepartmentName by d.DepartmentID;
            foreach (var item in results)
            {
                Console.WriteLine($"{item.FirstOrDefault()} : {item.Count()}");
            }
        }
    }
}
