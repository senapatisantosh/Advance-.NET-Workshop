using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo.LinqDemo
{
    class BasicLinq
    {
        public static void BasicLinqSyntax()
        {
            // Create a Simple Linq
            int[] arrayIntegers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            //var evenNumbers = from num in arrayIntegers
            //                  where num % 2 == 0
            //                  select num;

            var evenNumbers = arrayIntegers.Where(num => num % 2 == 0)
                                           .Select(num => num);


            foreach (var item in evenNumbers)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}
