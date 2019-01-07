namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_6
{
    public interface Command
    {
        void Execute();
        void Undo();
    }
}