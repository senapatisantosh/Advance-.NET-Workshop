using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadDemo
{
    using System;
    using System.Threading;

    public class Program
    {
        public static void Main()
        {
            //Race Condition

            Thread[] tArray = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                tArray[i]= new Thread(Program.DoWork);
                tArray[i].Start($"Name of the Child Thread {Thread.CurrentThread.Name}{i}");
            }
            Console.WriteLine("Program Ends");
            Console.ReadKey();
        }

        public static void DoWork(object data)
        {

            Console.WriteLine(data.ToString());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
