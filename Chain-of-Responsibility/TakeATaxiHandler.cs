namespace Chain_of_Responsibility
{
    public abstract class TakeATaxiHandler : IHandler
    {
        protected IHandler successor;

        public abstract ResponseContext Execute(RequestContext requestContext);

        public IHandler SetSuccessor(IHandler handler)
        {
            successor = handler;
            return successor;
        }
    }
}
