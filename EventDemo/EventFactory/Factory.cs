using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventFactory
{
    public class Factory
    {
        public delegate void EventSupportedDelegate();
        public event EventSupportedDelegate EventSupportedDelegateHandler;
        public Factory()
        {

        }

        protected void factoryDefaultHandler()
        {
            if (EventSupportedDelegateHandler!=null)
            {
                EventSupportedDelegateHandler();
            }
        }

        public void GreetMorning()
        {
            Console.WriteLine("Good Morning");
            factoryDefaultHandler();
        }
        public void GreetAfterNoon()
        {
            Console.WriteLine("Good AfterNoon");
            factoryDefaultHandler();
        }
        public void GreetEvening()
        {
            Console.WriteLine("Good Evening");
            factoryDefaultHandler();
        }

    }
}
