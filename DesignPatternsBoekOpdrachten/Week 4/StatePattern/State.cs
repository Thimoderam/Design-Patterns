namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_10
{
    public interface State
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}