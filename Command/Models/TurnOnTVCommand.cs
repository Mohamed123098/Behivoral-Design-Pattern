using Command.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Models
{
    internal class TurnOnTVCommand(TV tv) : ICommandDesignPattern
    {
        public void ExecuteCommand()
        {
            tv.TrunOn();
        }
    }
}
