using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreadSynchronizationTechniques.Synchronization;

namespace ThreadSynchronizationTechniques
{
    /// <summary>
    /// Topics to be Covered 
    ///     Interlocked,
    ///     lock, 
    ///     Monitor, 
    ///     SemaphoreSlim, 
    ///     Synchronization, 
    ///     Mutex 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region InterLocked Lock Monitor
            //InterlockedDemo interlockedDemo = new InterlockedDemo();
            //LockDemo lockDemo = new LockDemo();
            //MonitorClassDemo monitorClassDemo = new MonitorClassDemo();
            //List<Task> tasks = new List<Task>();
            //for (int j = 0; j < 2; j++)
            //{
            //    Task t1 = Task.Factory.StartNew(() =>
            //    {
            //        for (int i = 0; i < 10; i++)
            //        {
            //            monitorClassDemo.Hit(10);
            //        }
            //    });
            //    tasks.Add(t1);
            //    Task t2 = Task.Factory.StartNew(() =>
            //    {
            //        for (int i = 0; i < 10; i++)
            //        {
            //            monitorClassDemo.Heal(10);
            //        }
            //    });
            //    tasks.Add(t2);
            //}
            //Task.WaitAll(tasks.ToArray());
            //Console.WriteLine($"Health Score : {monitorClassDemo.HealthScore}"); 
            #endregion

            #region Semaphoreslim

            SemaphoreSlimdemo SemaphoreSlimdemo = new SemaphoreSlimdemo();

            SemaphoreSlimdemo.OpenNightClub(10, 15);

            #endregion
            Console.WriteLine("+++++++++++++++++++Hello++++++++++++++++");
            Console.ReadKey();
        }
    }
}
