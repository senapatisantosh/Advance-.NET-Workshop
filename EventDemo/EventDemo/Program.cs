using EventFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EventFactory.Factory;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            factory.EventSupportedDelegateHandler += new EventSupportedDelegate(customEventhandler);
            EventSupportedDelegate eventSupported = 
                            new EventSupportedDelegate(factory.GreetMorning);
            eventSupported += factory.GreetAfterNoon;
            eventSupported += factory.GreetEvening;
            eventSupported();
            Console.ReadKey();

        }

        private static void customEventhandler()
        {
            Console.WriteLine("Event Fired");
        }
    }
}
