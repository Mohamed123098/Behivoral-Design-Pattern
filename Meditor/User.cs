using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditor
{
    internal class User(IChatManagement ChatManagement)
    {
        //public IChatManagement ChatManagement { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public void SendDirectMessage(string message,User user )
        {
            ChatManagement.SendMessage(message, this, user);
        }
        public void SendGroupMessage(string message,string groupName)
        {
            ChatManagement.SendGroupMessage(message, groupName, this);
                        
        }
        public void RecieveDirectMessage(string message, User user)
        {
            Console.WriteLine($"{Name} is Recieving {{{message}}} from {user.Name} ");
        }
        public void RecieveGroupMessage(string message, string groupName, User user)
        {
            Console.WriteLine($"{Name} is Recieving {{{message}}} from {user.Name} who is in group#{groupName}# ");
        }

    }
}
