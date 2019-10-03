using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Event.Notifications;

namespace Event
{
    public class EventDemo
    {
        public static List<string> ReturnArray = new List<string>();
        static void Main(string[] args)
        {
            List<string> stringArry = new List<string>();
            Notification notification = new Notification(GreetEvening);
            notification += GreetMorning;
            Notifications.notificationEventHandler += new Notification(EventHandlerNotify);
            notification(null,new StringArg("Santosh"));
            foreach (var item in ReturnArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static string EventHandlerNotify(object o, StringArg e)
        {
            ReturnArray.Add(e.data);
            return "";
        }


    }
}
