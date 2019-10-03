using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqDemo
{
    class LinqToXMLDemo
    {
        public static void LinqToXMLExample()
        {
            //LinQ Class to load one XML
            XElement xElement = XElement.Load("Employees.xml");

            //Load the XML Elements
            IEnumerable<XElement> result = xElement.Elements();

            //Linq to Get Employee Names
            var employeeNames = from emp in result
                                select emp.Element("Name").Value;

            //Print
            foreach (var item in employeeNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
