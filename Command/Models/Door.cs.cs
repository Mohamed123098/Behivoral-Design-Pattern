using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Models
{
    internal class Door:BaseModel
    {
        public  void Lock()
        {
            Console.WriteLine($"{Name} is Locked.....");
        }
        public void Unlock()
        {
            Console.WriteLine($"{Name} is unlocked.....");
        }
    }
}
