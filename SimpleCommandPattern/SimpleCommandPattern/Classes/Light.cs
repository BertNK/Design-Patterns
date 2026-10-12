using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommandPattern.Classes
{
    internal class Light
    {
        private string location;
        public Light(string location) 
        {
            this.location = location;
        }
        public void On()
        {
            Console.WriteLine("Light is on");
        }

        public void Off()
        {
            Console.WriteLine("Light is off");

        }
    }
}
