using MulticastEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationProject.Notification
{
    public class MAILNotification : MCEvents
    {
        public static string SendMailNotification<T>(T username)
        {
            string result = "MAIL SENT";
            new MCEvents().LogResult(result);
            return result;
        }
    }
}
