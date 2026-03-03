using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models
{
    internal class User:ISubscriber
    {
        public string Name { get; set; } = default!;
        public Address Address { get; set; } = default!;
        //public bool isSubscribedToProducts { get; set; }
        //public bool isSubscribedToOffers { get; set; }
        //public void Notify(Product product)
        //{
        //    Console.WriteLine($"Hello...{Name} {product.Name} is added to our marketplace");
        //}
        //public void Notify(Offer offer)
        //{
        //    Console.WriteLine( $"Hello...{Name} we have offer {{{offer.Message}}}");
        //}

        public void Notify(string Message)
        {
            Console.WriteLine($"Notifying ..{Name} about {{{Message}}}");
        }

        public override string ToString()
        {
            return $"Name : {Name} Address :{Address}";
        }
    }
}
