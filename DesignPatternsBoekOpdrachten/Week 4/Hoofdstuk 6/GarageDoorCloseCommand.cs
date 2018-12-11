namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_6
{
    public class GarageDoorCloseCommand : Command
    {
        private GarageDoor door;

        public GarageDoorCloseCommand(GarageDoor door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Close();
        }

        public void Undo()
        {
            door.Open();
        }
    }
}
