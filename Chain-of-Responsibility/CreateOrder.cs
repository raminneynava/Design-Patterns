namespace Chain_of_Responsibility
{
    public class CreateOrder : TakeATaxiHandler
    {
        public override ResponseContext Execute(RequestContext requestContext)
        {
            bool orderCreated = true;
            if (orderCreated)
            {
                Console.WriteLine("Order Created...");
                if (successor != null)
                {
                    return successor.Execute(requestContext);
                }
            }
            return new ResponseContext
            {
                IsSuccess = false,
                Message = "Error Order Created"
            };
        }
    }
}
