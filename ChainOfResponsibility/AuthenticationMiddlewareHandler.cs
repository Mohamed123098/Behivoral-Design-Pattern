using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class AuthenticationMiddlewareHandler : AbstractMiddlewareHandler
    {
        public override bool Handle(Request request)
        {
            Console.WriteLine("Authentication");
           if(!request.IsAuthenticated)
            {
                return false;
            }
            return base.Handle(request);
        }
    }
}
