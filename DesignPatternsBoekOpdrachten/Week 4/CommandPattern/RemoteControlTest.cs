using System;

namespace DesignPatternsBoekOpdrachten.Week_4.Hoofdstuk_6
{
    public class RemoteControlTest
    {
        public RemoteControlTest()
        {
            var light = new Light();
            var garageDoor = new GarageDoor();

            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);
            var doorOpen = new GarageDoorOpenCommand(garageDoor);
            var doorClose = new GarageDoorCloseCommand(garageDoor);

            var remote = new RemoteControl();
            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(1, doorOpen, doorClose);

            Console.WriteLine(remote);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            remote.UndoButtonWasPushed();
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);
            remote.UndoButtonWasPushed();
        }
    }
}