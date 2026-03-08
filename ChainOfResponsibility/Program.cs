namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RequestProcessor requestProcessor = new();
            requestProcessor.MiddlewareHandler = new AuthenticationMiddlewareHandler().SetNext(new AuthorizationMiddlewareHandler());
            Request request = new() { IsAuthenticated = true, IsAuthorized = true, IsSecured=true, Name="Request01", Type="RequestType" };
            Console.WriteLine(requestProcessor.ProcessRequest(request).IsSuccess+"  "+requestProcessor.ProcessRequest(request).Reason);
           
        }
    }
}
