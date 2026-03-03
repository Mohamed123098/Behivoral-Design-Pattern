namespace Observer.Models
{
    public interface ISubscriber
    {
        void Notify(string Message);
    }
}