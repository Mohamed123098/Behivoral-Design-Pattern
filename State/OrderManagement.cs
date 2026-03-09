using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class OrderManagement
    {
        public Order Order { get; set; }
        public IOrderState State { get; set; }
        public OrderManagement()
        {
            State = new NewOrderState(this);
        }
        public void ProcessOrder()
        {
            State.ProcessedOrder();
            
            
        }
        public void ShippedOrder()
        {
            State.ShippedOrder();
           
        }
        public void DeliveredOrder()
        {
            State.DeliveredOrder();
            
        }
        public void CancelledOrder()
        {
            State.CancelledOrder();
        }
        public void ChangeState(IOrderState orderState)
        {
            State = orderState;
        }
    }

    
}
