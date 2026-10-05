using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("DVD player on");
        }
        public void Off()
        {
            Console.WriteLine("DVD player off");
        }
        public void Eject()
        {
            Console.WriteLine("DVD ejected");
        }
        public void Pause()
        {
            Console.WriteLine("DVD paused");
        }
        public void Play(string movie)
        {
            Console.WriteLine($"DVD playing \"{movie}\"");
        }
        public void SetSurroundAudio()
        {
            Console.WriteLine("DVD audio set to surround sound");
        }
        public void SetTWoChannelAudio()
        {
            Console.WriteLine("DVD audio set to two-channel sound");
        }
        public void Stop()
        {
            Console.WriteLine("DVD stopped");
        }
    }
}
