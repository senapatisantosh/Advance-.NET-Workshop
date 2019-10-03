using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSynchronizationTechniques.Synchronization
{
    public class SemaphoreSlimdemo
    {
        public SemaphoreSlim bouncers { get; set; }
        public void OpenNightClub(int noOfPeople, int available)
        {
            List<Task> tasks = new List<Task>();

            // Night Capacity is the First Parameter , Availability 2nd Parameter
            bouncers = new SemaphoreSlim(available);

            // Create noof Pepople wants to enter into the night CLub
            for (int i = 0; i < noOfPeople; i++)
            {
                int num = i;
                Task t = Task.Factory.StartNew(() => Guest(num));
                tasks.Add(t);
            }
            Task.WaitAll(tasks.ToArray());
        }
        private void Guest(int i)
        {
            bouncers.Wait();
            Console.WriteLine($"Guest {i + 1} Enters the Club");

            Console.WriteLine($"Guest {i + 1} Dance");
            Thread.Sleep(3000);

            Console.WriteLine($"Guest {i + 1} leaves the Club");
            bouncers.Release();
        }
    }
}
