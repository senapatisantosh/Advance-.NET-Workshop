using MulticastEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationProject.Notification
{
    public class FAXNotification : MCEvents
    {
        public static string SendFaxNotification<T>(T username)
        {
            string result = "FAX SENT";
            new MCEvents().LogResult(result);
            return result;
        }
    }
}
