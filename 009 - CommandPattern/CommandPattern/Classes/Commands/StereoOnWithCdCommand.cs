using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class StereoOnWithCdCommand : Command
    {
        private readonly Stereo stereo;
        private readonly Stack<Stereo.State> previousStates = new();

        public StereoOnWithCdCommand(Stereo stereo)
        {
            this.stereo = stereo ?? throw new ArgumentNullException(nameof(stereo));
        }

        public void Execute()
        {
            previousStates.Push(stereo.CaptureState());
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(11);
        }

        public void Undo()
        {
            stereo.RestoreState(previousStates.Pop());
        }
    }
}
