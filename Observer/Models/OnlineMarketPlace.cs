using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models
{
    internal class OnlineMarketPlace
    {
        public string Name { get; set; } = default!;
        public Dictionary<EventType,List<ISubscriber>> Subscribers { get; set; } = [];
        public List<Product> Products { get; set; } = [];
        public List<Offer> Offers { get; set; } = [];
        public List<JobOffer> JobOffers { get; set; } = [];
        public OnlineMarketPlace()
        {
            Subscribers.Add(EventType.New_Product, []);
            Subscribers.Add(EventType.New_Offer, []);
            Subscribers.Add(EventType.Job_Offer, []);
        }
        public void AddSubscriber(EventType eventType, ISubscriber subscriber)
        {
            Subscribers[eventType].Add(subscriber);
        }
        public void AddProduct(Product product) {
            Products.Add(product);
            NotifySubscribers(EventType.New_Product, $"Notifying .. {product.Name} is Added");
        }

        private void NotifySubscribers(EventType eventType, string message)
        {
            Subscribers[eventType].ForEach(subscriber =>
            {
                subscriber.Notify(message);
            });
        }

        public void AddOffer(Offer offer)
        {
            Offers.Add(offer);
            NotifySubscribers(EventType.New_Offer, $"Notifying New offer is added{{{offer.Message}}}");
            
        }
        
        public void Unsubscribe(EventType eventType,ISubscriber subscriber)
        {
            Subscribers[eventType].Remove(subscriber);
        }

        public void AddJobOffer(JobOffer jobOffer)
        {
            JobOffers.Add(jobOffer);
            NotifySubscribers(EventType.Job_Offer, $"Notify...{jobOffer.Title} is available");
        }


    }
}
