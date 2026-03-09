using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class DeliveredOrderState : IOrderState
    {
        public void CancelledOrder()
        {
            Console.WriteLine("Order can't be cancelled because it is already Delivered!");
        }

        public void DeliveredOrder()
        {
            Console.WriteLine("Order is already Delivered"); 
        }

        public void ProcessedOrder()
        {
            Console.WriteLine("Order can't be processed because it is delivered"); 
        }

        public void ShippedOrder()
        {
            Console.WriteLine("Order can't be Shipped because it is delivered");

        }
    }
}
