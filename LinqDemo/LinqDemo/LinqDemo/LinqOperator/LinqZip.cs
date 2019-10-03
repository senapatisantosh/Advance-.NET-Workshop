using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo.LinqDemo.LinqOperator
{
    class LinqZip
    {
        public static void PartioningExample()
        {
            List<int> nos1 = new List<int>() { 1, 4, 4, 2, 3, 4, 5, 6, 78, 9 };
            List<int> nos2 = new List<int>() { 2, 3, 4, 2, 12, 45, 34, 54, 656, 6 };
            
            //var results = from num1 in nos1
            //              from num2 in nos2
            //              where num1 > num2
            //              select new
            //              {
            //                  FirstNumber = num1,
            //                  SecondNumber = num2
            //              };

            var results = nos1.Zip(nos2, (x, y) => 
            {
                if (x < y)
                    return new
                    {
                        FirstNumber = x,
                        SecondNumber = y
                    };
                else
                    return null;
            })
            .Where(z => z != null);

            foreach (var item in results)
            {
                Console.WriteLine($"{item.FirstNumber} : {item.SecondNumber}");
            }

        }
    }
}
