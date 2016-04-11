using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesWinner
{
    class SweepstakesStackManager : ISweepstakeManager
    {
            Stack<Sweepstakes> sweepstakesstack = new Stack<Sweepstakes>();       
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesstack.Push(sweepstakes);
        }
        public Sweepstakes GetNextSweepstakesWinner()
        {
            return sweepstakesstack.Pop();
        }
    }
}
