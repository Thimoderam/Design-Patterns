using System.Text;

namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_6
{
    public class RemoteControl
    {
        private Command[] onCommands;
        private Command[] offCommands;
        private Command undoCommand;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];

            Command noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }
        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }
        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }
        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\n------ Remote Control -------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                builder.Append($"[slot {i}] {onCommands[i].GetType().Name} : {offCommands[i].GetType().Name}\n");
            }
            return builder.ToString();
        }
    }
}
