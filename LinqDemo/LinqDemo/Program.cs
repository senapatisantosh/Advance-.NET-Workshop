using LinqDemo.LinqDemo;
using LinqDemo.LinqDemo.LinqOperator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Basic Linq
            //BasicLinq.BasicLinqSyntax();

            //Defered and Imme. Execution in LINQ
            //DeferedAndImmediateExecution.DeferedExecutionLINQ();
            //DeferedAndImmediateExecution.ImmediateExecutionLINQ();

            //Parallel Linq
            //PLinqDemo.ParallelExecutionLINQ();

            //Linq Operators
            //LinqZip.PartioningExample();
            //OfTypeDemo.OfTypeExample();
            //ElementLinQ.GetElementExample();
            //QuatifierDemo.GetQuantifierExample();
            //SetExample.GetSetExample();
            //ProjectionExample.GetProjectionExample();
            //JoinDemo.GetJoinExample();

            //LinQ TO XML
            LinqToXMLDemo.LinqToXMLExample();


            Console.ReadKey();
        }
    }
}
