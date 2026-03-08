using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class AuthorizationMiddlewareHandler : AbstractMiddlewareHandler
    {
       
        public override bool Handle(Request request)
        {
            Console.WriteLine("Authorization");
            if(!request.IsAuthorized)
            {
                return false;
            }
            return base.Handle(request);
        }
    }
}
