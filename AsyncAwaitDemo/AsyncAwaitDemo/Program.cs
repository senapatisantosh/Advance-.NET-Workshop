using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Task.Factory.StartNew(() => PrintTheNumber(i));
            }
            Console.ReadKey();
        }
        static void PrintTheNumber(int num)
        {
            Thread.Sleep(200);
            Console.WriteLine($"The Current No is : {num}");
        }
    }
}
