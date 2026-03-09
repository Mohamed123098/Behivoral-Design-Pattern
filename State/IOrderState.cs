using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal interface IOrderState
    {
        void ProcessedOrder();
        void ShippedOrder();
        void DeliveredOrder();
        void CancelledOrder();

    }
}
