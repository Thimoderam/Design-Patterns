using System;

namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_10
{
    public class NoQuarterState : State
    {
        private readonly GumballMachine gumballMachine;
        private const string StateName = "NoQuarterState";

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't iserted a quarter.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter.");
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but you need to pay first.");
        }
        public override string ToString()
        {
            return StateName;
        }
    }
}
