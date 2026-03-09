using Command.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command.Models
{
    internal class LockDoorCommand(Door door) : ICommandDesignPattern
    {
        public void ExecuteCommand()
        {
            door.Lock();
        }
    }
}
