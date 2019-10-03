using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo.Model
{
    [Serializable]
    public class Employee
    {
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
