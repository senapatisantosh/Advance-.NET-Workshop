using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20;
            Console.WriteLine(i.Square());
            string name = "Santosh Kumar Senapati";
            string result = name.Greet();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
