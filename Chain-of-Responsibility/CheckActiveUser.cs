namespace Chain_of_Responsibility
{
    public class CheckActiveUser : TakeATaxiHandler
    {
        public override ResponseContext Execute(RequestContext requestContext)
        {
            if (requestContext.UserId != 1)
            {
                Console.WriteLine("User Not Active...");
                return new ResponseContext
                {
                    IsSuccess = false,
                    Message = "Error Check Active User"
                };
            }

            else if (successor != null)
            {
                Console.WriteLine("User Is Active...");
                return successor.Execute(requestContext);
            }
            else
            {
                return new ResponseContext
                {
                    IsSuccess = false,
                    Message = "Error Check Active User"
                };
            }
        }
    }

}