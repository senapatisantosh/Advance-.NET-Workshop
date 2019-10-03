using FileIODemo.FileIOExtensionMethods;
using FileIODemo.Model;
using FileIODemo.SerializationsTech;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string result = File.ReadAllLines("a.txt").GetContentWithLineno<string>(10);
            //Console.WriteLine(result);

            List<Employee> employees = ConstructEmployeeObjs();
            string myProjectDirectory = Directory.GetParent("../../").FullName;

            #region Binary Serialization and Deserialization

            //BinarySerializationDemo.EmployeeDataBinarySerialization(employees, myProjectDirectory);
            //BinarySerializationDemo.GetEmployeeBinaryData(myProjectDirectory); 

            #endregion

            #region XML Serialization

            //XMLSerializationDemo.EmployeeDataXMLSerialization(employees, myProjectDirectory);
            //XMLSerializationDemo.GetEmployeeXMLData(myProjectDirectory);

            #endregion

            #region JSON Serialization

            //JsonSerializationDemo.EmployeeDataJSONSerialization(employees, myProjectDirectory);
            //JsonSerializationDemo.GetEmployeeJSONData(myProjectDirectory);

            #endregion

            Console.WriteLine("Employee Data Saved in a Json File");
            Console.ReadKey();

        }






        private static List<Employee> ConstructEmployeeObjs()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee();
            emp1.ID = 1;
            emp1.EmployeeName = "Santosh";
            emp1.PhoneNumber = "989899898";
            Employee emp2 = new Employee();
            emp2.ID = 2;
            emp2.EmployeeName = "asdgjhasdasd";
            emp2.PhoneNumber = "989899898";
            Employee emp3 = new Employee();
            emp3.ID = 3;
            emp3.EmployeeName = "Sanasdasdasdtosh";
            emp3.PhoneNumber = "9898449898";
            Employee emp4 = new Employee();
            emp4.ID = 4;
            emp4.EmployeeName = "Santoasdasdassh";
            emp4.PhoneNumber = "989899898";
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);
            return employees;
        }
    }
}
