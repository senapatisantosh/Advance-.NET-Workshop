using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSynchronizationTechniques.Synchronization
{
    internal class InterlockedDemo
    {
        private int _healthScore = 0;
        public int HealthScore { get => _healthScore;
                                private set => _healthScore = value; }
        public void Heal(int damage)
        {
            Interlocked.Add(ref _healthScore, damage);
        }
        public void Hit(int health)
        {
            Interlocked.Add(ref _healthScore, -health);
        }
    }
}
