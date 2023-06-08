// See https://aka.ms/new-console-template for more information





public class Apapter : Target
{
    private Adaptee _adaptee;
    public Apapter()
    {
        _adaptee = new Adaptee();
    }

    public override void Operation()
    {
        _adaptee.SpecificOperation();
    }
}