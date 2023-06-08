// See https://aka.ms/new-console-template for more information












public abstract class Mediator
{
    protected ConcreateColleague1 _colleague1;
    protected ConcreateColleague2 _colleague2;

    protected Mediator(ConcreateColleague1 colleague1, ConcreateColleague2 colleague2)
    {
        _colleague2 = colleague2;
        _colleague1 = colleague1;
    }

    public abstract void NotifyChange(string message, Colleague colleague);
}
