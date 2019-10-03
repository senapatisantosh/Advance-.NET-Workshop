using IRCTCBOOKING;
using MulticastEvent;
using NotificationProject.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IRCTCBOOKING.IRCTCBooking;

namespace DelegateandEventsDemo
{
    class Program
    {
        public static List<string> Results = new List<string>();
        static void Main(string[] args)
        {
            BookTicketandSendAllNotification();

            Console.ReadKey();
        }

        static void BookTicketandSendAllNotification()
        {
            //IRCTCBooking.BookTicket();
            //SendNotification obj = new SendNotification(FAXNotification.SendFaxNotification);
            //obj += MAILNotification.SendMailNotification;
            //obj += SMSNotification.SendSMSNotification;
            //obj += OFFLINENotification.SendOfflineNotification;
            //obj("Santosh");
            MCEvents.SendNotificationHanler += new Func<object, StringArgv, object>(CustomEventHandler);
            Func<string,string> obj = new Func<string, string>(FAXNotification.SendFaxNotification);
            obj += MAILNotification.SendMailNotification;
            obj += SMSNotification.SendSMSNotification;
            obj += OFFLINENotification.SendOfflineNotification;
            obj += XYZNotification.SendXYZNotification;
            IRCTCBooking.BookTicket<string>(obj, "Santosh");
            foreach (var item in Results.ToArray<string>())
            {
                Console.WriteLine(item);
            }
        }

        private static object CustomEventHandler(object arg1, StringArgv arg2)
        {
            Results.Add($"Notification Fired : {arg2.data}");
            return Results;
        }
    }



}
