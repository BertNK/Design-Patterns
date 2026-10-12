using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class GarageDoorDownCommand : Command
    {
        private readonly GarageDoor garageDoor;
        private readonly Stack<bool> previousStates = new();

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor ?? throw new ArgumentNullException(nameof(garageDoor));
        }

        public void Execute()
        {
            previousStates.Push(garageDoor.IsOpen);
            garageDoor.Down();
        }

        public void Undo()
        {
            if (previousStates.Pop())
            {
                garageDoor.Up();
            }
            else
            {
                garageDoor.Down();
            }
        }
    }
}
