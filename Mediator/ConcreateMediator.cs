// See https://aka.ms/new-console-template for more information












public class ConcreateMediator : Mediator
{
    public ConcreateMediator(ConcreateColleague1 colleague1, ConcreateColleague2 colleague2):base(colleague1, colleague2)
    {

    }
    public override void NotifyChange(string message, Colleague colleague)
    {
       if(colleague== _colleague1)
        {
            _colleague2.Recive(message);

        }
        else
        {
            _colleague1.Recive(message);
        }
    }
}
