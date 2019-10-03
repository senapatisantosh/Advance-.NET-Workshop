using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentCollectionDemo.ConcurrentCollection
{
    internal class ConcurrentBagDemo
    {
        public static void HandleConcurrentBag()
        {
            const int NO_OF_MESSAGES = 200;
            const int NO_OF_THREADS = 10;
            ConcurrentBag<string> bag = new ConcurrentBag<string>();
            int MessageProcessed = 0;
            List<Task> tasks = new List<Task>();

            for (int i = 0; i < NO_OF_MESSAGES; i++)
            {
                bag.Add($"Message {i + 1}");
            }

            Console.WriteLine("Waiting For Good Connectivity .........");
            Thread.Sleep(2000);
            Console.WriteLine("Mobile Network Connected .........");

            for (int i = 0; i < NO_OF_THREADS; i++)
            {

                Task tempTask = Task.Factory.StartNew(
                                        () => SendMessage(NO_OF_MESSAGES, bag, ref MessageProcessed
                                    ));
                tasks.Add(tempTask);
            }
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine($"Message Processed : {MessageProcessed}");
        }
        private static void SendMessage(int NO_OF_MESSAGES, ConcurrentBag<string> bag, ref int MessageProcessed)
        {
            for (int i = 0; i < NO_OF_MESSAGES; i++)
            {
                if (bag.Count == 0)
                {
                    return;
                }
                Thread.Sleep(50);
                string temp = String.Empty;
                if (bag.TryTake(out temp))
                {
                    Interlocked.Add(ref MessageProcessed, 1);
                    Console.WriteLine($"Processed Message {temp}");
                }
            }
        }
    }
}
