using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class Stereo
    {
        internal readonly record struct State(bool IsOn, string? Input, int Volume);

        public bool IsOn { get; private set; }
        public string? Input { get; private set; }
        public int Volume { get; private set; }

        public void On()
        {
            IsOn = true;
            Console.WriteLine("Stereo was turned on");
        }

        public void Off()
        {
            IsOn = false;
            Console.WriteLine("Stereo was turned off");
        }

        public void SetCD()
        {
            Input = "CD";
            Console.WriteLine("Stereo was turned to CD mode");
        }

        public void SetDVD()
        {
            Input = "DVD";
            Console.WriteLine("Stereo was turned to DVD mode");
        }

        public void SetRadio()
        {
            Input = "Radio";
            Console.WriteLine("Stereo was turned to Radio mode");
        }

        public void SetVolume(int volume)
        {
            Volume = volume;
            Console.WriteLine("Stereo volume set to " + volume);
        }

        internal State CaptureState()
        {
            return new State(IsOn, Input, Volume);
        }

        internal void RestoreState(State state)
        {
            IsOn = state.IsOn;
            Input = state.Input;
            Volume = state.Volume;
            Console.WriteLine($"Stereo state restored (on: {IsOn}, input: {Input ?? "none"}, volume: {Volume})");
        }
    }
}
