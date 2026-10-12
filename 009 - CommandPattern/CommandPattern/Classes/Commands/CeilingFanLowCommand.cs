using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanLowCommand : Command
    {
        private readonly CeilingFan ceilingFan;
        private readonly Stack<int> previousSpeeds = new();

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan ?? throw new ArgumentNullException(nameof(ceilingFan));
        }

        public void Execute()
        {
            previousSpeeds.Push(ceilingFan.GetSpeed());
            ceilingFan.Low();
        }

        public void Undo()
        {
            RestoreSpeed(previousSpeeds.Pop());
        }

        private void RestoreSpeed(int speed)
        {
            switch (speed)
            {
                case 0: ceilingFan.Off(); break;
                case 1: ceilingFan.Low(); break;
                case 2: ceilingFan.Medium(); break;
                case 3: ceilingFan.High(); break;
                default: throw new InvalidOperationException($"Unknown ceiling fan speed: {speed}.");
            }
        }
    }
}
