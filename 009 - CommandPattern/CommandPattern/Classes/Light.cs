using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class Light
    {
        private readonly string location;
        public bool IsOn { get; private set; }

        public Light(string location) 
        {
            this.location = location;
        }

        public void On()
        {
            IsOn = true;
            Console.WriteLine($"{location} Light is turned on");
        }

        public void Off()
        {
            IsOn = false;
            Console.WriteLine($"{location} Light is turned off");
        }
    }
}
