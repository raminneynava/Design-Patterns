// See https://aka.ms/new-console-template for more information












public class ConcreateColleague2 : Colleague
{
    public override void Send(string message)
    {
        Console.WriteLine($"ConcreateColleague2 send:{message}");
        base.Send(message);
    }

    public void Recive(string message)
    {
        Console.WriteLine($"Concreate2 Recive:{message}");
    }
}