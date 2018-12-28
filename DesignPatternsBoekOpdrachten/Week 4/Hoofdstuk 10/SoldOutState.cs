using System;

namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_10
{
    public class SoldOutState : State
    {
        private const string StateName = "SoldOutState";
        public void Dispense()
        {
            Console.WriteLine("Can't dispense, out of gumballs.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Ejecting your quarter.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("The gumballs are sold out.");
        }
        public override string ToString()
        {
            return StateName;
        }
    }
}
