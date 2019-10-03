using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSynchronizationTechniques.Synchronization
{
    internal class LockDemo
    {
        public int HealthScore { get; private set; }
        private readonly object synObject = new object();
        public void Heal(int damage)
        {
            lock (synObject)
            {
                HealthScore += damage;
            }
        }
        public void Hit(int health)
        {
            lock (synObject)
            {
                HealthScore -= health;

            }
        }
    }
}
