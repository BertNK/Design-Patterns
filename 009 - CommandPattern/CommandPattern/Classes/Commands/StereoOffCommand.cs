using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class StereoOffCommand : Command
    {
        private readonly Stereo stereo;
        private readonly Stack<Stereo.State> previousStates = new();

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo ?? throw new ArgumentNullException(nameof(stereo));
        }

        public void Execute()
        {
            previousStates.Push(stereo.CaptureState());
            stereo.Off();
        }

        public void Undo()
        {
            stereo.RestoreState(previousStates.Pop());
        }
    }
}
