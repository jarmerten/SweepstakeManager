using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesWinner
{
    interface ISweepstakeManager
    {
        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetNextSweepstakesWinner();
    }
}
