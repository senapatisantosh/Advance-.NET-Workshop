using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo.LinqDemo.LinqOperator
{
    class ElementLinQ
    {
        public static void GetElementExample()
        {
            List<int> nos1 = new List<int>() { 1, 4, 4, 2, 3, 4, 5, 6, 78, 9 };

            foreach (var item in nos1.OrderByDescending(x=>x).Take(6).Distinct())
            {
                Console.WriteLine(item);
            }
        }
    }
}
