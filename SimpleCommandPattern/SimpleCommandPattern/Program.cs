using SimpleCommandPattern.Classes;
using SimpleCommandPattern.Classes.Commands;

namespace SimpleCommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light("Garage");

            LightOnCommand lightOnCommand = new LightOnCommand(light);
            remote.SetCommand(lightOnCommand);
            remote.ButtonWasPressed();

            LightOffCommand lightOffCommand = new LightOffCommand(light);
            remote.SetCommand(lightOffCommand);
            remote.ButtonWasPressed();

            var garageDoor = new GarageDoor(light);
            var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
            remote.SetCommand(garageDoorOpenCommand);
            remote.ButtonWasPressed();
        }
    }
}