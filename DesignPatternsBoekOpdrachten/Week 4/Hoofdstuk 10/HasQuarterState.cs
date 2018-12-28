using System;

namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_10
{
    public class HasQuarterState : State
    {
        private readonly GumballMachine gumballMachine;
        private readonly Random randomWinner = new Random();
        private const string StateName = "HasQuarterState";

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter ejected.");
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned....");
            int winner = randomWinner.Next(0, 10);
            if ((winner == 2) && (gumballMachine.GetCount() > 1))
            {
                gumballMachine.SetState(gumballMachine.GetWinnerState());
            }
            else
            {
                gumballMachine.SetState(gumballMachine.GetSoldState());
            }

        }

        public override string ToString()
        {
            return StateName;
        }
    }
}
