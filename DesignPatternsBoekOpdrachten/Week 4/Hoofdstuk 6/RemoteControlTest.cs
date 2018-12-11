namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_6
{
    public class RemoteControlTest
    {
        public RemoteControlTest()
        {
            Light light = new Light();
            GarageDoor garageDoor = new GarageDoor();

            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);
            GarageDoorOpenCommand doorOpen = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand doorClose = new GarageDoorCloseCommand(garageDoor);

            RemoteControl remote = new RemoteControl();
            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(1, doorOpen, doorClose);

            System.Console.WriteLine(remote);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            remote.UndoButtonWasPushed();
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);
            remote.UndoButtonWasPushed();
        }
    }
}
