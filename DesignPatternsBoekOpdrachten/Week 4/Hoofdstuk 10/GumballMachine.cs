using System;

namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_10
{
    public class GumballMachine
    {
        private readonly State soldOutState;
        private readonly State noQuarterState;
        private readonly State hasQuarterState;
        private readonly State soldState;
        private readonly State winnerState;
        private State currentState;
        private int gumballCount;
        public GumballMachine(int numberOfGumballs)
        {
            soldOutState = new SoldOutState();
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            gumballCount = numberOfGumballs;
            if (gumballCount > 0)
                currentState = noQuarterState;
            else
                currentState = soldOutState;
        }

        public void InsertQuarter()
        {
            currentState.InsertQuarter();
        }
        public void EjectQuarter()
        {
            currentState.EjectQuarter();
        }
        public void TurnCrank()
        {
            currentState.TurnCrank();
            currentState.Dispense();
        }
        public void SetState(State state)
        {
            currentState = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out of the slot....");
            if (gumballCount > 0)
            {
                gumballCount--;
            }
        }

        public State GetSoldOutState()
        {
            return soldOutState;
        }

        public State GetNoQuarterState()
        {
            return noQuarterState;
        }

        public State GetHasQuarterState()
        {
            return hasQuarterState;
        }

        public State GetSoldState()
        {
            return soldState;
        }
        public State GetWinnerState()
        {
            return winnerState;
        }

        public State GetCurrentState()
        {
            return currentState;
        }

        public int GetCount()
        {
            return gumballCount;
        }

        public override string ToString()
        {
            return $"{nameof(soldOutState)}: {soldOutState}, {nameof(noQuarterState)}: {noQuarterState}, {nameof(hasQuarterState)}: {hasQuarterState}, {nameof(soldState)}: {soldState}, {nameof(winnerState)}: {winnerState}, {nameof(currentState)}: {currentState}, {nameof(gumballCount)}: {gumballCount}";
        }
    }
}
