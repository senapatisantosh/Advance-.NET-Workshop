using FileIODemo.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo.SerializationsTech
{
    public class JsonSerializationDemo
    {
        public static void EmployeeDataJSONSerialization(List<Employee> employees, string myProjectDirectory)
        {


            using (FileStream fileStream = new FileStream(
                                        $@"{myProjectDirectory}\employee.json",
                                        FileMode.Create,
                                        FileAccess.Write
                                    ))
            {
                string empJsonObj = JsonConvert.SerializeObject(employees);
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine(empJsonObj);
                }
            }
        }

        public static void GetEmployeeJSONData(string myProjectDirectory)
        {
            List<Employee> result;
            using (FileStream fileStream = new FileStream(
                                        $@"{myProjectDirectory}\employee.json",
                                        FileMode.Open,
                                        FileAccess.Read
                                    ))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    result = JsonConvert.DeserializeObject<List<Employee>>(streamReader.ReadToEnd()); 
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine("===============================");
                Console.WriteLine(item.ID);
                Console.WriteLine(item.EmployeeName);
                Console.WriteLine(item.PhoneNumber);
            }
        }
    }
}
