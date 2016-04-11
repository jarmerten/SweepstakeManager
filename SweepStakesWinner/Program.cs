using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesWinner
{
    class Program
    {
        static void Main(string[] args)
        {
            SweepstakesStackManager stacksweeps = new SweepstakesStackManager();
            SweepstakesQueueManager queuesweeps = new SweepstakesQueueManager();

            Contestant jared = new Contestant("Jared");
            Contestant derek = new Contestant("Derek");
            Contestant m = new Contestant("Mike");
            Contestant brad = new Contestant("Brad");
            Contestant jim = new Contestant("Jim");

            Sweepstakes vacay = new Sweepstakes("Vacation");
            Sweepstakes car = new Sweepstakes("Free Car");


            vacay.RegisterContestant(jared);
            vacay.RegisterContestant(derek);
            vacay.RegisterContestant(m);

            car.RegisterContestant(brad);
            car.RegisterContestant(jim);

            stacksweeps.InsertSweepstakes(vacay);
            stacksweeps.InsertSweepstakes(car);
            queuesweeps.InsertSweepstakes(vacay);
            queuesweeps.InsertSweepstakes(car);

            string name = stacksweeps.GetNextSweepstakesWinner().PickWinner();
            Console.WriteLine("The winner of a vacation is " + name);
            Console.ReadLine();
        }
    }
}
