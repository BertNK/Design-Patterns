using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class LightOnCommand : Command
    {
        private readonly Light light;
        private readonly Stack<bool> previousStates = new();

        public LightOnCommand(Light light)
        {
            this.light = light ?? throw new ArgumentNullException(nameof(light));
        }

        public void Execute()
        {
            previousStates.Push(light.IsOn);
            light.On();
        }

        public void Undo()
        {
            if (previousStates.Pop())
            {
                light.On();
            }
            else
            {
                light.Off();
            }
        }
    }
}
