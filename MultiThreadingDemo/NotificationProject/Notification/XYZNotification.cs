using MulticastEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationProject.Notification
{
    public class XYZNotification : MCEvents
    {
        public static string SendXYZNotification<T>(T username)
        {
            string result = "XYZ SENT";
            new MCEvents().LogResult(result);
            return result;
        }
    }
}
