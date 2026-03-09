using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class NewOrderState(OrderManagement OrderManagement) : IOrderState
    {
        //private OrderManagement OrderManagement { get; set; }
        public void CancelledOrder()
        {
            Console.WriteLine("Order is cancelled successfully");
            OrderManagement.State = new CancelledOrderState();
        }

        public void DeliveredOrder()
        {
            Console.WriteLine("Order can't be delivered ");
        }

        public void ProcessedOrder()
        {
            Console.WriteLine("Order is processed successfully ");
            OrderManagement.State = new ProcessingOrderState(OrderManagement);
        }

        public void ShippedOrder()
        {
            Console.WriteLine("Order can't be shipped");
        }
    }
}
