using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        private static int passedChecks;

        static void Main(string[] args)
        {
            const int livingRoomLightSlot = 1;
            const int kitchenLightSlot = 2;
            const int ceilingFanSlot = 3;
            const int garageDoorSlot = 4;
            const int stereoSlot = 5;

            RemoteControl remoteControl = new RemoteControl();
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            Light garageLight = new Light("Garage");
            GarageDoor garageDoor = new GarageDoor(garageLight);
            Stereo stereo = new Stereo();

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);
            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(livingRoomLightSlot, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(kitchenLightSlot, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(ceilingFanSlot, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(garageDoorSlot, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(stereoSlot, stereoOnWithCd, stereoOff);

            Console.WriteLine(remoteControl);
            Console.WriteLine("Running command and undo checks...");

            remoteControl.UndoButtonWasPushed();
            Check("Undo on empty history is safe", 0, remoteControl.UndoHistoryCount);

            remoteControl.OnButtonWasPushed(livingRoomLightSlot);
            Check("Living-room light turns on", true, livingRoomLight.IsOn);
            remoteControl.UndoButtonWasPushed();
            Check("Undo restores the living-room light to off", false, livingRoomLight.IsOn);

            remoteControl.OnButtonWasPushed(livingRoomLightSlot);
            remoteControl.OnButtonWasPushed(livingRoomLightSlot);
            remoteControl.UndoButtonWasPushed();
            Check("Repeated command undo restores the preceding on state", true, livingRoomLight.IsOn);
            remoteControl.UndoButtonWasPushed();
            Check("Repeated command undo restores the original off state", false, livingRoomLight.IsOn);

            remoteControl.OnButtonWasPushed(livingRoomLightSlot);
            remoteControl.OffButtonWasPushed(livingRoomLightSlot);
            Check("Living-room light turns off", false, livingRoomLight.IsOn);
            remoteControl.UndoButtonWasPushed();
            Check("Undo of light-off restores the on state", true, livingRoomLight.IsOn);
            remoteControl.UndoButtonWasPushed();
            Check("Undo of light-on restores the off state", false, livingRoomLight.IsOn);

            remoteControl.OnButtonWasPushed(kitchenLightSlot);
            Check("Kitchen light turns on", true, kitchenLight.IsOn);
            remoteControl.OffButtonWasPushed(kitchenLightSlot);
            remoteControl.UndoButtonWasPushed();
            Check("Undo restores the kitchen light to on", true, kitchenLight.IsOn);
            remoteControl.UndoButtonWasPushed();
            Check("Undo restores the kitchen light to off", false, kitchenLight.IsOn);

            remoteControl.OnButtonWasPushed(ceilingFanSlot);
            Check("Ceiling fan high command sets speed 3", 3, ceilingFan.GetSpeed());
            remoteControl.OffButtonWasPushed(ceilingFanSlot);
            Check("Ceiling fan off command sets speed 0", 0, ceilingFan.GetSpeed());
            remoteControl.UndoButtonWasPushed();
            Check("Undo of fan-off restores high speed", 3, ceilingFan.GetSpeed());
            remoteControl.UndoButtonWasPushed();
            Check("Undo of fan-high restores off", 0, ceilingFan.GetSpeed());

            CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
            ceilingFanLow.Execute();
            Check("Ceiling fan low command sets speed 1", 1, ceilingFan.GetSpeed());
            ceilingFanLow.Undo();
            Check("Undo of fan-low restores off", 0, ceilingFan.GetSpeed());
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            ceilingFanMedium.Execute();
            Check("Ceiling fan medium command sets speed 2", 2, ceilingFan.GetSpeed());
            ceilingFanMedium.Undo();
            Check("Undo of fan-medium restores off", 0, ceilingFan.GetSpeed());

            remoteControl.OnButtonWasPushed(garageDoorSlot);
            Check("Garage-door up command opens the door", true, garageDoor.IsOpen);
            remoteControl.UndoButtonWasPushed();
            Check("Undo of garage-door up closes the door", false, garageDoor.IsOpen);
            remoteControl.OffButtonWasPushed(garageDoorSlot);
            Check("Garage-door down command closes the door", false, garageDoor.IsOpen);
            remoteControl.UndoButtonWasPushed();
            Check("Undo of garage-door down restores the previous closed state", false, garageDoor.IsOpen);
            remoteControl.OnButtonWasPushed(garageDoorSlot);
            remoteControl.OffButtonWasPushed(garageDoorSlot);
            remoteControl.UndoButtonWasPushed();
            Check("Undo of garage-door down restores an open door", true, garageDoor.IsOpen);
            remoteControl.UndoButtonWasPushed();
            Check("Undo of garage-door up restores a closed door", false, garageDoor.IsOpen);

            remoteControl.OnButtonWasPushed(stereoSlot);
            CheckStereoState("Stereo CD command", stereo, true, "CD", 11);
            remoteControl.UndoButtonWasPushed();
            CheckStereoState("Undo of stereo CD restores its original state", stereo, false, null, 0);

            stereo.On();
            stereo.SetDVD();
            stereo.SetVolume(20);
            remoteControl.OffButtonWasPushed(stereoSlot);
            CheckStereoState("Stereo-off command", stereo, false, "DVD", 20);
            remoteControl.UndoButtonWasPushed();
            CheckStereoState("Undo of stereo-off restores power, input, and volume", stereo, true, "DVD", 20);

            StereoOnWithDvdCommand stereoOnWithDvd = new StereoOnWithDvdCommand(stereo);
            stereoOnWithDvd.Execute();
            CheckStereoState("Stereo DVD command", stereo, true, "DVD", 11);
            stereoOnWithDvd.Undo();
            CheckStereoState("Undo of stereo DVD restores the prior state", stereo, true, "DVD", 20);

            StereoOnWithRadioCommand stereoOnWithRadio = new StereoOnWithRadioCommand(stereo);
            stereoOnWithRadio.Execute();
            CheckStereoState("Stereo radio command", stereo, true, "Radio", 11);
            stereoOnWithRadio.Undo();
            CheckStereoState("Undo of stereo radio restores the prior state", stereo, true, "DVD", 20);

            remoteControl.OnButtonWasPushed(livingRoomLightSlot);
            remoteControl.OnButtonWasPushed(kitchenLightSlot);
            remoteControl.UndoButtonWasPushed();
            Check("History undoes the most recent kitchen-light action first", false, kitchenLight.IsOn);
            Check("Undoing kitchen light leaves the earlier living-room action intact", true, livingRoomLight.IsOn);
            remoteControl.UndoButtonWasPushed();
            Check("The next undo restores the earlier living-room action", false, livingRoomLight.IsOn);

            remoteControl.OnButtonWasPushed(livingRoomLightSlot);
            remoteControl.OnButtonWasPushed(0);
            Check("Unused slots are not added to undo history", 1, remoteControl.UndoHistoryCount);
            remoteControl.UndoButtonWasPushed();
            Check("Undo after an unused slot still reverses the last real action", false, livingRoomLight.IsOn);

            Light macroLight = new Light("Macro Test");
            GarageDoor macroDoor = new GarageDoor(new Light("Macro Garage"));
            MacroCommand macro = new MacroCommand(new Command[]
            {
                new LightOnCommand(macroLight),
                new GarageDoorUpCommand(macroDoor)
            });
            macro.Execute();
            Check("Macro executes all commands", true, macroLight.IsOn && macroDoor.IsOpen);
            macro.Undo();
            Check("Macro undo restores all commands in reverse order", false, macroLight.IsOn || macroDoor.IsOpen);

            CheckThrows<ArgumentOutOfRangeException>(
                "Invalid remote slot is rejected",
                () => remoteControl.OnButtonWasPushed(7));

            Console.WriteLine($"All {passedChecks} checks passed.");
        }

        private static void Check<T>(string description, T expected, T actual)
        {
            if (!EqualityComparer<T>.Default.Equals(expected, actual))
            {
                throw new InvalidOperationException(
                    $"{description}: expected '{expected}', got '{actual}'.");
            }

            passedChecks++;
            Console.WriteLine($"PASS: {description}");
        }

        private static void CheckStereoState(
            string description,
            Stereo stereo,
            bool expectedIsOn,
            string? expectedInput,
            int expectedVolume)
        {
            Check($"{description} - power", expectedIsOn, stereo.IsOn);
            Check($"{description} - input", expectedInput, stereo.Input);
            Check($"{description} - volume", expectedVolume, stereo.Volume);
        }

        private static void CheckThrows<TException>(string description, Action action)
            where TException : Exception
        {
            try
            {
                action();
            }
            catch (TException)
            {
                passedChecks++;
                Console.WriteLine($"PASS: {description}");
                return;
            }

            throw new InvalidOperationException($"{description}: expected {typeof(TException).Name}.");
        }
    }
}
