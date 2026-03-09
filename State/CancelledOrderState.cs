using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class CancelledOrderState : IOrderState
    {
        
        public void CancelledOrder()
        {
            Console.WriteLine("Order is already cancelled");
        }

        public void DeliveredOrder()
        {
            Console.WriteLine("Order can't be delivered it is cancelled");
        }

        public void ProcessedOrder()
        {
            Console.WriteLine("Order can't be Processed it is cancelled");

        }

        public void ShippedOrder()
        {
            Console.WriteLine("Order can't be Shipped it is cancelled");

        }
    }
}
