using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Response
    {
        public string Reason { get; set; }
        public bool IsSuccess { get; set; }
    }
}
