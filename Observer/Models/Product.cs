using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models
{
    internal class Product
    {
        public string Name { get; set; } = default!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return $"Name : {Name} | Price : {Price:.L.E} | Quantity : {Quantity}";
        }
    }
}
