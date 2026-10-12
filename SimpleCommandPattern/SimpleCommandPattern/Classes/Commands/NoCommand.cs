using SimpleCommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommandPattern.Classes.Commands
{
    internal class NoCommand : Command
    {
        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}
