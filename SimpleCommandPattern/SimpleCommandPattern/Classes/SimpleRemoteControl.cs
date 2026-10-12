using SimpleCommandPattern.Interfaces;
using SimpleCommandPattern.Classes.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommandPattern.Classes
{
    internal class SimpleRemoteControl
    {
        Command slot = new NoCommand();
        public SimpleRemoteControl()
        {

        }

        public void SetCommand(Command command) 
        { 
            slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
