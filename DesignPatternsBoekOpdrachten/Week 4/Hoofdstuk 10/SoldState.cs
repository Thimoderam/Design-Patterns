using System;

namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_10
{
    public class SoldState : State
    {
        private readonly GumballMachine gumballMachine;
        private const string StateName = "SoldState";
        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            gumballMachine.ReleaseBall();
            if (gumballMachine.GetCount() > 0)
            {
                gumballMachine.SetState(gumballMachine.GetNoQuarterState());
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs.");
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we are already giving you a gumball.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }
        public override string ToString()
        {
            return StateName;
        }
    }
}
