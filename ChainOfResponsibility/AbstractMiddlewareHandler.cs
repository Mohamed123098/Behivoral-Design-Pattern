using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal abstract class AbstractMiddlewareHandler:IMiddlewareHandler
    {
        public IMiddlewareHandler NextHandler { get; set; }
        public IMiddlewareHandler SetNext(IMiddlewareHandler middlewareHandler)
        {
            NextHandler = middlewareHandler;
            return NextHandler;
        }
       public virtual  bool Handle(Request request)
        {
            if(NextHandler !=null)
            {
                return NextHandler.Handle(request);
            }
            return true;
        }
    }
}
