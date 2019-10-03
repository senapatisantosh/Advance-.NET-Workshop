using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinqDemo.LinqDemo
{
    class PLinqDemo
    {
        public static IEnumerable<int> integerCollection { get; set; } 
                            = Enumerable.Empty<int>();
        public static void ParallelExecutionLINQ()
        {
            integerCollection = Enumerable.Range(1, 10000000);

            var results = integerCollection
                          .AsParallel()
                          .Where(x => x % 1234567 == 0 && x % 4 == 0);
            results.ForAll((e) => Dosomething(e));
        }

        private static void Dosomething(int e)
        {
            Thread.Sleep(1000);
            Console.WriteLine(e);
        }
    }
}
