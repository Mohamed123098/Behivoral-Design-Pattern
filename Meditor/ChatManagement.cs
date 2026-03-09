
namespace Meditor
{
    
    internal class ChatManagement : IChatManagement
    {
        public Dictionary<string, List<User>> GroupUsers { get; set; } = [];
        public void AddGroup(string GroupName)
        {
            GroupUsers.Add(GroupName, new());
        }
        public void RegisterUserToGroup(string groupName, User user)
        {
            GroupUsers[groupName].Add(user);
        }

        public void SendGroupMessage(string message, string groupName, User user)
        {
            GroupUsers[groupName].ForEach(userInGroup =>
            {
                if (userInGroup.Name == user.Name)
                    return;
                userInGroup.RecieveGroupMessage(message,groupName, user);
            });
        }

        public void SendDirectMessage(string message, User sender, User reciever)
        {
            reciever.RecieveDirectMessage(message, sender);
        }
    }
}
