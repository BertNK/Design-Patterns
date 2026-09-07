using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.QuackBehavior
{
    public class RegularQuack : QuackBehavior
    {
            public void Quack()
            {
                Console.WriteLine("Quack!");
            }
    }
}
