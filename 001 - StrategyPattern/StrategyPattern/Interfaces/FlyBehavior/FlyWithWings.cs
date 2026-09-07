using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.FlyBehavior
{
    public class FlyWithWings : FlyBehavior
    {
            public void Fly()
            {
                Console.WriteLine("I can fly!");
            }
    }
}
