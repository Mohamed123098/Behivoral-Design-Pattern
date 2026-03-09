using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Models
{
    internal class TV : BaseModel
    {
        public void TrunOn()
        {
            Console.WriteLine($"{Name} is turned on .....");
        }
        public void TrunOff()
        {
            Console.WriteLine($"{Name} is turned off .....");
        }
    }
}
