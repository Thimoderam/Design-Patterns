namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_6
{
    public class GarageDoorOpenCommand : Command
    {
        private GarageDoor door;
        public GarageDoorOpenCommand(GarageDoor door)
        {
            this.door = door;
        }
        public void Execute()
        {
            door.Open();
        }

        public void Undo()
        {
            door.Close();
        }
    }
}
