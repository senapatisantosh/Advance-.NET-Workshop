using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo.LinqDemo.LinqOperator
{
    class QuatifierDemo
    {
        public static void GetQuantifierExample()
        {
            List<int> nos1 = new List<int>() { 1, 4, 3, 3, 3, 3, 5, 3, 3, 9 };
            //nos1.Any(x => x % 2 == 0)
            if (nos1.All(x => x % 2 != 0))
            {
                Console.WriteLine("Condition Satisfied");
            }
        }
    }
}
