using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        private static readonly object lockObj = new object();
        private static ConcurrentQueue<int> RandomNumberQueue = new ConcurrentQueue<int>();
        static void Main(string[] args)
        {
            Parallel.Invoke(Producer, Consumer);
            Console.ReadKey();
        }
        private static void Producer()
        {
            while (true)
            {
                int a = new Random().Next();
                lock (lockObj)
                {
                    if (a % 2 == 0)
                    {
                        RandomNumberQueue.Enqueue(a);
                        Monitor.Pulse(lockObj);
                    }
                }
            }
        }
        private static void Consumer()
        {
            int evenNum = 0;
            while (true)
            {
                lock (lockObj)
                {
                    Monitor.Wait(lockObj);
                    RandomNumberQueue.TryDequeue(out evenNum);
                    Console.WriteLine(evenNum);
                }
            }
        }
    }
}

