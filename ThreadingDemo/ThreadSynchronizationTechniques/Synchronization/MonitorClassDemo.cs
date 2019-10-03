using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThreadSynchronizationTechniques.ExtentionMethods;

namespace ThreadSynchronizationTechniques.Synchronization
{
    internal class MonitorClassDemo
    {
        public int HealthScore { get; private set; }
        private readonly object synObject = new object();
        public void Heal(int damage)
        {
            using (synObject.MonitorLockBoilerPlate(TimeSpan.FromSeconds(30)))
            {
                HealthScore += damage;
            }
        }
        public void Hit(int health)
        {
            using (synObject.MonitorLockBoilerPlate(TimeSpan.FromSeconds(30)))
            {
                HealthScore -= health;
            }
        }
    }
}
