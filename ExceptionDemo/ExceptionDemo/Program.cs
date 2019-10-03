using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);

            #region Exception Demo
            int i = 0;
            int j = 1;
            try
            {
                Console.WriteLine(j / i);

            }

            catch (DivideByZeroException ex)
            {

                string InnerException_lineno = ex.StackTrace.Split(' ').LastOrDefault();
                Console.WriteLine("I am CATCH block");

                // Custom Error to files
                // Log to the Data
                // Logging to the ConsoleWindow
                new MyCustomException("Divide B Zero from Custom Exception", new Exception($"InnerException With LINE no: {InnerException_lineno}"));
                throw;

            }
            catch (Exception ex)
            {
                Console.WriteLine("I am CATCH block");
                Console.WriteLine($"From Base Exception Class {ex.Message}");
            }


            finally
            {
                Console.WriteLine("I am Finally block");
                Console.ReadKey();
            }

            #endregion

            #region MyFirstCustom InnerException
            //try
            //{
            //    try
            //    {
            //        var num = int.Parse("abc");
            //    }
            //    catch (Exception inner)
            //    {
            //        try
            //        {
            //            var openLog = File.Open("DoesNotExist", FileMode.Open);
            //        }
            //        catch
            //        {
            //            throw new FileNotFoundException("OutterException", inner);
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    string inMes, outMes;
            //    if (e.InnerException != null)
            //        inMes = e.InnerException.Message;
            //    outMes = e.Message;
            //}

            #endregion


        }

        #region My Unhandeled code exception

        static void MyHandler(object sender, UnhandledExceptionEventArgs args)
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
        }

        #endregion
    }
}
