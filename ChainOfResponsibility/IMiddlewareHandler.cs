using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal interface IMiddlewareHandler
    {
        IMiddlewareHandler SetNext(IMiddlewareHandler middlewareHandler);
        bool Handle(Request request);
    }
}
