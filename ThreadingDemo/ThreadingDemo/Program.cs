using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //How to define Parameterless Thread
            //Thread t = new Thread(new ThreadStart(hello));
            //Thread t = new Thread(hello);
            //Thread t = new Thread(() => hello());
            //t.Start();

            //How to define Parameterize Thread
            //Thread t = new Thread(new ParameterizedThreadStart(hello));
            //Thread t = new Thread(hello);
            //Thread t = new Thread(() => hello("hfsdfgsd"));

            //t.Start();
            //t.Join(3500);

            //Task Parallel Library

            //string a = Task.Run(() => hello("Main Thread")).Result;
            Task.Factory.StartNew(() => hello("Main Thread"));
            Console.WriteLine($"Output String");
            Console.WriteLine("Program Ends");
            Console.ReadKey();
        }
        public static void hello(object name)
        {
            Console.WriteLine($"Foreground thread is working..............");
            Thread.Sleep(3000);
            Console.WriteLine($"I am a Thread {name.ToString()}");
        }
    }
}
