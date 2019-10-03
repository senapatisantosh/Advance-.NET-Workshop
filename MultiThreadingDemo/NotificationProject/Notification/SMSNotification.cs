using MulticastEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationProject.Notification
{
    public class SMSNotification : MCEvents
    {
        public static string SendSMSNotification<T>(T username)
        {
            string result = "SMS SENT";
            new MCEvents().LogResult(result);
            return result;
        }
    }
}
