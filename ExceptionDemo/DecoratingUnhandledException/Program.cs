using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratingUnhandledException
{
    class Program
    {
       
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyCustomUnhadledEventListner);
            int i = 0;
            int j = 1;
            Console.WriteLine(j / i);
        }

        private static void MyCustomUnhadledEventListner(object sender, UnhandledExceptionEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Exception e = (Exception)args.ExceptionObject;

            Console.WriteLine("=====================DECORATING UNHANDELED EXCEPTION ===========================");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("MyHandler caught : " + e.Message);
            Console.WriteLine("Runtime terminating: {0}", args.IsTerminating);
            Console.WriteLine("                                                                                ");
            Console.WriteLine("================================================================================");
            //supress Expression


        }
    }
}
