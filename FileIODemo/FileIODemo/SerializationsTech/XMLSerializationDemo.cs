using FileIODemo.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIODemo.SerializationsTech
{
    public class XMLSerializationDemo
    {
        public static void EmployeeDataXMLSerialization(List<Employee> employees, string myProjectDirectory)
        {


            using (FileStream fileStream = new FileStream(
                                        $@"{myProjectDirectory}\employee.xml",
                                        FileMode.Create,
                                        FileAccess.Write
                                    ))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>));
                xmlSerializer.Serialize(fileStream, employees);
            }
        }

        public static void GetEmployeeXMLData(string myProjectDirectory)
        {
            List<Employee> result;
            using (FileStream fileStream = new FileStream(
                                        $@"{myProjectDirectory}\employee.xml",
                                        FileMode.Open,
                                        FileAccess.Read
                                    ))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>));
                result = (List<Employee>)xmlSerializer.Deserialize(fileStream);
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
