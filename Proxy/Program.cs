// See https://aka.ms/new-console-template for more information
using Proxy;


ISubject Subject = new ProxySubject();

Subject.DoAction();

Console.ReadKey();