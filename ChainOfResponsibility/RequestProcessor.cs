using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class RequestProcessor
    {
        public IMiddlewareHandler MiddlewareHandler { get; set; }
        public Response ProcessRequest(Request request)
        {
            if(MiddlewareHandler.Handle(request))
            {
                return new() { IsSuccess = true, Reason = "Successfully" };
            }
            return new() { Reason = "Failed", IsSuccess = false };
        }
       
    }
}
