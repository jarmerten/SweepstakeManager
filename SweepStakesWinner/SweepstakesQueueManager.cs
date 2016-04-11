using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesWinner
{
    class SweepstakesQueueManager : ISweepstakeManager
    {
        Queue<Sweepstakes> sweepstakesstack = new Queue<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesstack.Enqueue(sweepstakes);
        }
        public Sweepstakes GetNextSweepstakesWinner()
        {
            return sweepstakesstack.Dequeue();
        }
    }
}
