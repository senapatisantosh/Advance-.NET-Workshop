using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Notifications
    {
        //1. Create A delegate which two Parameters By 




        //public delegate void EventHandler(object sender, EventArgs e);
        public delegate string Notification(object o, StringArg e);
        public static event Notification notificationEventHandler;
        

        public static string result = null;
        public static string GreetEvening(object o, StringArg e)
        {
            result = $"Good Evening {e.data}";
            new Notifications().OnGreetingsEnd(result);
            return result;
        }
        public static string GreetMorning(object o, StringArg e)
        {
            result = $"Good Morning {e.data}";
            new Notifications().OnGreetingsEnd(result);
            return result;
        }
        protected void OnGreetingsEnd(object obj)
        {
            if (notificationEventHandler != null)
            {
                notificationEventHandler(this, new StringArg(obj.ToString()));
            }
        }
    }

    class StringArg: EventArgs
    {
        public string data { get; set; }
        public StringArg(string data)
        {
            this.data = data;
        }
    }
}
