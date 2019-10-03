using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentCollectionDemo.ConcurrentCollection
{
    internal class ConcurrentQueueDemo
    {
        public static void HandleConcurrentQueue()
        {
            const int NO_OF_MESSAGES = 200;
            const int NO_OF_THREADS = 10;
            ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
            int MessageProcessed = 0;
            List<Task> tasks = new List<Task>();

            for (int i = 0; i < NO_OF_MESSAGES; i++)
            {
                queue.Enqueue($"Message {i + 1}");
            }

            Console.WriteLine("Waiting For Good Connectivity .........");
            Thread.Sleep(2000);
            Console.WriteLine("Mobile Network Connected .........");

            for (int i = 0; i < NO_OF_THREADS; i++)
            {

                Task tempTask = Task.Factory.StartNew(
                                        () => SendMessage(NO_OF_MESSAGES, queue, ref MessageProcessed
                                    ));
                tasks.Add(tempTask);
            }
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine($"Message Processed : {MessageProcessed}");
        }
        private static void SendMessage(int NO_OF_MESSAGES, ConcurrentQueue<string> queue, ref int MessageProcessed)
        {
            for (int i = 0; i < NO_OF_MESSAGES; i++)
            {
                if (queue.Count == 0)
                {
                    return;
                }
                Thread.Sleep(50);
                string temp = String.Empty;
                if (queue.TryDequeue(out temp))
                {
                    Interlocked.Add(ref MessageProcessed, 1);
                    Console.WriteLine($"Processed Message {temp}");
                }
            }
        }
    }
}
