using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace Listing_17
{
    class BankAccount
    {
        public int Balance { get; set; }
        static void Main(string[] args)
        {
            #region ConCurrent QUEUE/Stack/BAG

            ConcurrentQueue<long> sharedQueue = new ConcurrentQueue<long>();
            for (long i = 0; i < 100000; i++)
            {
                sharedQueue.Enqueue(i);
            }
            int itemCount = 0;
            Task[] tasks = new Task[2];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = new Task(() =>
                {
                    while (sharedQueue.Count > 0)
                    {
                        long queueElement;
                        bool gotElement = sharedQueue.TryDequeue(out queueElement);
                        if (gotElement)
                        {
                            Interlocked.Increment(ref itemCount);
                        }
                    }
                });
                tasks[i].Start();
            }
            Task.WaitAll(tasks);
            Console.WriteLine("Items processed: {0}", itemCount);

            #endregion

            #region Cocurrent Dictionary

            //BankAccount account = new BankAccount();
            //ConcurrentDictionary<object, int> sharedDict = new ConcurrentDictionary<object, int>();
            //Task<int>[] tasks = new Task<int>[10];
            //for (int i = 0; i < tasks.Length; i++)
            //{
            //    sharedDict.TryAdd(i, account.Balance);
            //    tasks[i] = new Task<int>((keyObj) => {
            //        int currentValue;
            //        bool gotValue;
            //        for (int j = 0; j < 1000; j++)
            //        {
            //            gotValue = sharedDict.TryGetValue(keyObj, out currentValue);
            //            sharedDict.TryUpdate(keyObj, currentValue + 1, currentValue);
            //        }
            //        int result;
            //        gotValue = sharedDict.TryGetValue(keyObj, out result);
            //        if (gotValue)
            //        {
            //            return result;
            //        }
            //        else
            //        {
            //            throw new Exception(
            //            String.Format("No data item available for key {0}", keyObj));
            //        }
            //    }, i);
            //    tasks[i].Start();
            //}
            //for (int i = 0; i < tasks.Length; i++)
            //{
            //    account.Balance += tasks[i].Result;
            //}
            //Console.WriteLine("Expected value {0}, Balance: {1}", 10000, account.Balance);

            #endregion

            #region Blocking Collection



            #endregion

            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}