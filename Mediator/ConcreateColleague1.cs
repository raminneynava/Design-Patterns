// See https://aka.ms/new-console-template for more information












public class ConcreateColleague1 : Colleague
{
    public override void Send(string message)
    {
        Console.WriteLine($"ConcreateColleague1 send:{message}");
        base.Send(message);
    }

    public void Recive(string message)
    {
        Console.WriteLine($"ConcreateColleague1 Recive:{message}");
    }
}
