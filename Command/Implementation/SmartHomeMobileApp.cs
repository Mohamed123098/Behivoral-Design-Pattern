using Command.Abstraction;
using Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Implementation
{
    internal class SmartHomeMobileApp()
    {
        public void Execute(ICommandDesignPattern command)
        {
            command.ExecuteCommand();
        }

    }
}
