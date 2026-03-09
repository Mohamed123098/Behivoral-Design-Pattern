namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderManagement orderManagement = new() { Order = new() { Name = "Jacket", Price = 800 } };
            orderManagement.ProcessOrder();
            orderManagement.ProcessOrder();
            orderManagement.ShippedOrder();
            orderManagement.CancelledOrder();
            orderManagement.DeliveredOrder();
        }
    }
}
