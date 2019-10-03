using MulticastEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationProject.Notification
{
    public class OFFLINENotification : MCEvents
    {
        public static string SendOfflineNotification<T>(T username)
        {
            string result = "SENT OFLINE";
            new MCEvents().LogResult(result);
            return result;
        }
    }
}
