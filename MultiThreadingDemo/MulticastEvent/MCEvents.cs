using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastEvent
{
    public class MCEvents
    {
        public static event Func<object, StringArgv, object> SendNotificationHanler;
        public void LogResult(object obj)
        {
            if (SendNotificationHanler != null)
            {
                SendNotificationHanler(this, new StringArgv(obj.ToString()));
            }
        }
    }
    public class StringArgv : EventArgs
    {
        public string data { get; set; }
        public StringArgv(string data)
        {
            this.data = data;
        }
    }
}
