using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSynchronizationTechniques.ExtentionMethods
{
    public static class MonitorExtentionMethod
    {
        public static Lock MonitorLockBoilerPlate(this object obj,TimeSpan t)
        {
            bool lockToken = false;
            try
            {
                Monitor.TryEnter(obj, t, ref lockToken);
                if (lockToken)
                {
                    return new Lock(obj);
                }
                throw new TimeoutException();
            }
            catch
            {
                throw new Exception("Deadlock Happened");
            }
        }

        public class Lock : IDisposable
        {
            private readonly object _obj;
            public Lock(object obj)
            {
                _obj = obj;
            }
            public void Dispose()
            {
                Monitor.Exit(_obj);
            }
        }
    }
}
