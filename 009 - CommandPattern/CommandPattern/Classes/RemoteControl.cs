using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class RemoteControl
    {
        private readonly Command[] onCommands = new Command[7];
        private readonly Command[] offCommands = new Command[7];
        private readonly Stack<Command> history = new();

        public RemoteControl()
        {
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
        }

        // This method must set the On and Off command to the slot provided
        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            ValidateSlot(slot);
            ArgumentNullException.ThrowIfNull(onCommand);
            ArgumentNullException.ThrowIfNull(offCommand);
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        // This method must call the OnCommand.Execute() method of the slot provided
        public void OnButtonWasPushed(int slot)
        {
            ValidateSlot(slot);
            Command command = onCommands[slot];
            command.Execute();
            RememberUnlessEmptySlot(command);
        }

        // This method must call the OffCommand.Execute() method of the slot provided
        public void OffButtonWasPushed(int slot)
        {
            ValidateSlot(slot);
            Command command = offCommands[slot];
            command.Execute();
            RememberUnlessEmptySlot(command);
        }

        public void UndoButtonWasPushed()
        {
            if (history.Count == 0)
            {
                Console.WriteLine("Nothing to undo");
                return;
            }

            history.Pop().Undo();
        }

        internal int UndoHistoryCount => history.Count;

        private void RememberUnlessEmptySlot(Command command)
        {
            if (command is not NoCommand)
            {
                history.Push(command);
            }
        }

        private static void ValidateSlot(int slot)
        {
            if ((uint)slot >= 7)
            {
                throw new ArgumentOutOfRangeException(nameof(slot), "Slot must be between 0 and 6.");
            }
        }

        // Overwritten ToString() to print out each slot and its corresponding command.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n----- Remote Control ----- \n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.Append("[slot " + i + "] " + onCommands[i].GetType().Name + " \t\t  " + offCommands[i].GetType().Name + "\n");
            }
            return sb.ToString();
        }
    }
}
