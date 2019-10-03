using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableandIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            PropExample1 obj1 = new PropExample1();
            PropExample2 obj2 = new PropExample2();
            obj1.FirstNum = 100;
            obj1.SecondNum = 100;
            //Console.WriteLine(obj1.FirstNum);
            Console.WriteLine(obj1.SecondNum);
            //Console.WriteLine(obj2.Print1());
            Console.WriteLine(obj2.Print2());
            Console.ReadKey();
        }
    }
    class PropExample1
    {
        public int SecondNum;
        public int FirstNum { get; set; }
    }

    class PropExample2
    {
        public int Print1()
        {
            PropExample1 obj = new PropExample1();
            return obj.FirstNum;
        }
        public int Print2()
        {
            PropExample1 obj = new PropExample1();
            return obj.SecondNum;
        }
    }
}
