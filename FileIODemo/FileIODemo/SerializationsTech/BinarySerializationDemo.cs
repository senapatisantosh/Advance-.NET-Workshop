using FileIODemo.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo.SerializationsTech
{
    public class BinarySerializationDemo
    {
        public static void GetEmployeeBinaryData(string myProjectDirectory)
        {
            List<Employee> result;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream(
                                        $@"{myProjectDirectory}\employee.binary",
                                        FileMode.Open,
                                        FileAccess.Read
                                    ))
            {
                result = (List<Employee>)binaryFormatter.Deserialize(fileStream);
            }

            foreach (var item in result)
            {
                Console.WriteLine("===============================");
                Console.WriteLine(item.ID);
                Console.WriteLine(item.EmployeeName);
                Console.WriteLine(item.PhoneNumber);
            }
        }

        public static void EmployeeDataBinarySerialization(List<Employee> employees, string myProjectDirectory)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream(
                                        $@"{myProjectDirectory}\employee.binary",
                                        FileMode.Create,
                                        FileAccess.Write
                                    ))
            {
                binaryFormatter.Serialize(fileStream, employees);
            }
        }
    }
}
