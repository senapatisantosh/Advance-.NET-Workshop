using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo.LinqDemo.LinqOperator
{
    class SetExample
    {
        public static void GetSetExample()
        {
            List<int> nos1 = new List<int>() { 1, 4, 3, 3, 3, 3, 5, 3, 3, 9 };
            List<int> nos2 = new List<int>() { 1, 4, 565,43,5 };

            //foreach (var item in nos1.Except(new List<int>() { 3, 5 }))
            //{
            //    Console.WriteLine(item);
            //}

            foreach (var item in nos1.Union(nos2))
            {
                Console.WriteLine(item);
            }


        }
    }
}
