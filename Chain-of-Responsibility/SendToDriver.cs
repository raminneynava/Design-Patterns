namespace Chain_of_Responsibility
{
    public class SendToDriver : TakeATaxiHandler
    {
        public override ResponseContext Execute(RequestContext requestContext)
        {

            Console.WriteLine("Send To Driver...");
            if (successor != null)
            {
                return successor.Execute(requestContext);
            }
            return new ResponseContext
            {
                IsSuccess = false,
                Message = "Error Order Created and Send To Driver"
            };
        }
    }
}
