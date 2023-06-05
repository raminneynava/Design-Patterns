// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

using FactoryMethod;
using FactoryMethod.FactoryMethod;

//--------------------------------------
Console.WriteLine("Hello, World!");
var Create = new ConcreateCreator();
Product p;
p = Create.factory(0);
p.Excute();

//--------------------------------------


IEmailManager _email;
ICreator creator= new FactoryMethod.FactoryMethod.Creator();
_email = creator.FactoryMethod();
_email.Send(new EmailDto
{
    To = "example@email.com",
    From = "example@email.com",
    Message = "Send By Google"
});

Console.ReadKey();

