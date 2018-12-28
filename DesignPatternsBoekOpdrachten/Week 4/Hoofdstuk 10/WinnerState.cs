using System;

namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_10
{
    public class WinnerState : State
    {
        private readonly GumballMachine gumballMachine;
        private const string StateName = "WinnerState";
        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            gumballMachine.ReleaseBall();
            if(gumballMachine.GetCount() > 0)
            {
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
            else
            {
                gumballMachine.ReleaseBall();
                Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter.");
                if(gumballMachine.GetCount() > 0)
                {
                    gumballMachine.SetState(gumballMachine.GetNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs.");
                    gumballMachine.SetState(gumballMachine.GetSoldOutState());
                }
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("A gumball is already on it's way.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You already inserted a quarter.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You have already turned the crank.");
        }
        public override string ToString()
        {
            return StateName;
        }
    }
}
