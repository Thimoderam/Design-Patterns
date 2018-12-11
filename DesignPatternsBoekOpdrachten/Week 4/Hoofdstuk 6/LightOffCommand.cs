namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_6
{
    public class LightOffCommand : Command
    {
        private Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.Off();
        }

        public void Undo()
        {
            light.On();
        }
    }
}
