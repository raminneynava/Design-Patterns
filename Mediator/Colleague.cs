// See https://aka.ms/new-console-template for more information












public abstract class Colleague
{
    protected Mediator _mediator;
    public void SetMediator(Mediator mediator)
    {
        _mediator = mediator;
    }

    public virtual void Send(string message)
    {
        _mediator.NotifyChange(message, this);
    }
}
