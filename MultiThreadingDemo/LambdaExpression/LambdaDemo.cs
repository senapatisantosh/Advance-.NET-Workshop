using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class LambdaDemo
    {
        public static long fact = 1;
        static void Main(string[] args)
        {
            long num = Convert.ToInt64(Console.ReadLine());
            Func<long, long> func = null;
            func = (x) =>
            {
                if (num > 1)
                {
                    fact *= num;
                    func(--num);
                }
                return fact;
            };

            Console.WriteLine(func(num));
            Console.ReadKey();
        }
    }
}
