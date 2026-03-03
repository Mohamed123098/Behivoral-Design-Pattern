namespace Observer.Models
{
    public class Address
    {
        public string Street { get; set; } = default!;
        public string  City { get; set; } = default!;
        public string Country { get; set; } = default!;
        public override string ToString()
        {
            return $"Street : {Street} | City : {City} | Country : {Country}";
        }
    }
}