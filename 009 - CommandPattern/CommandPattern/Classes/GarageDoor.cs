using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class GarageDoor
    {
        private readonly Light light;
        public bool IsOpen { get; private set; }

        public GarageDoor(Light light)
        { 
            this.light = light;
        }

        public void Up()
        {
            IsOpen = true;
            Console.WriteLine("Door is open");
        }

        public void Down() 
        {
            IsOpen = false;
            Console.WriteLine("Door is closed");
        }

        public void Stop()
        {
            Console.WriteLine("Door stopped moving");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage door");
            light.On();
        }

        public void LightOff()
        {
            Console.WriteLine("Garage door");
            light.Off();
        }
    }
}
