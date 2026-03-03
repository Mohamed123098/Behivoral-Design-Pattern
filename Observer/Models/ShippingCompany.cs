using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models
{
    internal class ShippingCompany : ISubscriber
    {
        public string Name { get; set; }
        public void Notify(string Message)
        {
            Console.WriteLine($"Notifing...{Name} {{{Message}}}");
        }
    }
}
