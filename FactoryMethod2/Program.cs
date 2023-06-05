// See https://aka.ms/new-console-template for more information
using FactoryMethod2;

Console.WriteLine("Hello, World!");


IEmailManager emailManager;

IFactoryCreator creator = new GoogleEmailSend();

emailManager = creator.SendEmail();

emailManager.Send();