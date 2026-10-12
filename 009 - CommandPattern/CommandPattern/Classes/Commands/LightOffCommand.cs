using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class LightOffCommand : Command
    {
        private readonly Light light;
        private readonly Stack<bool> previousStates = new();

        public LightOffCommand(Light light)
        {
            this.light = light ?? throw new ArgumentNullException(nameof(light));
        }

        public void Execute()
        {
            previousStates.Push(light.IsOn);
            light.Off();
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
