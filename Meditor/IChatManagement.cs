using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditor
{
    internal interface IChatManagement
    {
        void SendDirectMessage(string message,User sender, User reciever);
        void SendGroupMessage(string message,string groupName , User user);
        void RegisterUserToGroup(string groupName, User user);
    }
}
