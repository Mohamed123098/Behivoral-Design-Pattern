using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class ProcessingOrderState(OrderManagement orderManagement) : IOrderState
    {
        public void CancelledOrder()
        {
            Console.WriteLine("Order is cancelled successfully ");
        }

        public void DeliveredOrder()
        {
            Console.WriteLine("Order can't be delivered");
        }

        public void ProcessedOrder()
        {
            Console.WriteLine("Order is already processed ");
            orderManagement.State = new ProcessingOrderState(orderManagement);
        }

        public void ShippedOrder()
        {
            Console.WriteLine("Order is Shipped Successfully ");
            orderManagement.State = new ShippedOrderState(orderManagement);
            
        }
    }
}
