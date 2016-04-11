using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesWinner
{
    class Sweepstakes
    {
        public int addAnotherContestant = 0;
        public string Name = null;
        Dictionary<int, Contestant> StoreSweepStake = new Dictionary<int, Contestant>();
        Random rnd;

        public Sweepstakes(string name)
        {
            Name = name;
            rnd = new Random();
        }
           public void RegisterContestant(Contestant contestant)
        {
            StoreSweepStake.Add(addAnotherContestant, contestant);
            addAnotherContestant++;
        }
            public string PickWinner()
        {
            int randomNumber = rnd.Next(1, addAnotherContestant);
            return StoreSweepStake[randomNumber].Username;
        }
            public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant);
        }
    }
}
