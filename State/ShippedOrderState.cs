using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class ShippedOrderState(OrderManagement orderManagement) : IOrderState
    {
        public void CancelledOrder()
        {
            Console.WriteLine("Order can't be cancelled ");
        }

        public void DeliveredOrder()
        {
            Console.WriteLine("Order delivered successfully");
            orderManagement.State = new DeliveredOrderState();

        }

        public void ProcessedOrder()
        {
            Console.WriteLine("Order Can't be Processed ");

        }

        public void ShippedOrder()
        {
            Console.WriteLine("Order is already shipped");

        }
    }
}
