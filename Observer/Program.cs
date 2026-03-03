using Observer.Models;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineMarketPlace marketPlace = new();
            //marketPlace.AddUser(new() { Name = "Muhammad", Address = new() { Street = "Hassan sarhan", City = "Nasr", Country = "Egypt" }, isSubscribedToOffers = true, isSubscribedToProducts = true });
            //marketPlace.AddUser(new() { Name = "Ahmed", Address = new() { Street = "Gamal Abdel nasr", City = "Madinat", Country = "USA" }, isSubscribedToOffers = true, isSubscribedToProducts = false });
            //marketPlace.AddUser(new() { Name = "Hadir", Address = new() { Street = "SAQ12", City = "Nasr", Country = "KSA" }, isSubscribedToOffers = false, isSubscribedToProducts = true });
            //marketPlace.AddUser(new() { Name = "Menna", Address = new() { Street = "Al bahran", City = "Suez", Country = "IRAQ" }, isSubscribedToOffers = false, isSubscribedToProducts = false });
            
            marketPlace.AddSubscriber(EventType.New_Product, new User
            {
                Name = "Muhammad",
                Address = new() { Street = "Hassan sarhan", City = "Nasr", Country = "Egypt" }
            });
            marketPlace.AddSubscriber(EventType.Job_Offer, new User
            {
                Name = "Mahmoud",
                Address = new() { Street = "Hassan sarhan", City = "Nasr", Country = "Egypt" }
            });
            var HDL = new ShippingCompany() { Name = "HDL" };
            marketPlace.AddSubscriber(EventType.New_Product,HDL);
            //marketPlace.Unsubscribe(EventType.New_Product, HDL);

          
            marketPlace.AddProduct(new() { Name = "PIZZA", Price = 200, Quantity = 10 });
            marketPlace.AddOffer(new() { Message = "Discount 20%" });
            marketPlace.AddJobOffer(new() { Title = "Senoir" });
        }
    }
}
