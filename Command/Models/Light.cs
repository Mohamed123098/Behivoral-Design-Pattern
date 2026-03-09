using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Models
{
    internal class Light : BaseModel
    {
        public void TrunOn()
        {
            Console.WriteLine($"{Name} light is turned on .....");
        }
        public void TrunOff()
        {
            Console.WriteLine($"{Name} light is turned off .....");
        }
    }
}
