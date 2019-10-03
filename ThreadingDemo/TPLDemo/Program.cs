using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(()=> Counter1()).ContinueWith((x)=> MessageBroadcast(x.Result));
            Console.ReadKey();
        }
        static int Counter1()
        {
            int j = 0;
            for (int i = 0; i < 1000; i++)
            {
                j += i;
            }
            return j;
        }
        static void MessageBroadcast(int j)
        {
            Console.WriteLine($"Final Score : {j}");
        }
    }
}
