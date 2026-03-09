using Command.Abstraction;
using Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Implementation
{
    internal class SmartHomeShortCut() 
    {
        Dictionary<string, ICommandDesignPattern> Commands = [];
        public void SetCommand(string command,ICommandDesignPattern commandDesignPattern)
        {
            Commands.Add(command, commandDesignPattern);
        }
        public void OpenShortCut(string command)
        {
            Commands[command].ExecuteCommand();
        }
        }
    }
