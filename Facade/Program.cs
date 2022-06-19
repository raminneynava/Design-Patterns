using System;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.doSomething();

            StaticFacade.doSomething();
        }
    }
}
