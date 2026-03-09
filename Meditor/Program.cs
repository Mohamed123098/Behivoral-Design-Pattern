namespace Meditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChatManagement chatManagement = new();
            User user01 = new(chatManagement) { Id = 1, Name = "Muhammad" };
            User user02 = new(chatManagement) { Id = 2, Name = "Ahmed" };
            User user03 = new(chatManagement) { Id = 1, Name = "Menna" };
            User user04 = new(chatManagement) { Id = 2, Name = "Hadir" };
            chatManagement.AddGroup("Final");
            chatManagement.RegisterUserToGroup("Final", user01);
            chatManagement.RegisterUserToGroup("Final", user02);
            chatManagement.RegisterUserToGroup("Final", user03);
            chatManagement.RegisterUserToGroup("Final", user04);
            user01.SendGroupMessage("Hello", "Final");



        }
    }
}
