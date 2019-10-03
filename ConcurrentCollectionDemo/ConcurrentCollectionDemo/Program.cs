using ConcurrentCollectionDemo.ConcurrentCollection;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentCollectionDemo
{
    /// <summary>
    /// How Messaging System Works in a mobile with your MObile Network 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //ConcurrentQueueDemo.HandleConcurrentQueue();
            //ConcurrentStackDemo.HandleConcurrentStack();
            ConcurrentBagDemo.HandleConcurrentBag();
            Console.ReadKey();
        }      
    }
}
