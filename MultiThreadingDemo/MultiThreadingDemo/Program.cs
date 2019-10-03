using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Thread[] threadArray = new Thread[1000];
            for (int i = 0; i < threadArray.Length; i++)
            {
                //Calling the constructor of the thread class 
                // and pass the function ref
                threadArray[i] = new Thread(Counter);
                threadArray[i].Name = "Child Thread : " + (i+1);
                threadArray[i].Start();
            }
            Console.WriteLine("MAin Thread Ends");
        }

        static void Counter()
        {
            for (int i = 0; i < 10; i++)
            {
                //int number = i;
                Console.WriteLine($"{Thread.CurrentThread.Name} : {i}");
                Thread.Sleep(10);
            }
        }
    }
}
