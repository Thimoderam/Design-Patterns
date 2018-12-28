namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_6
{
    public class LightOnCommand : Command
    {
        private readonly Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }
    }
}