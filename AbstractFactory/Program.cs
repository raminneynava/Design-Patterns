// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");


IFactory LabtopRam = new ConcreateRamFactory();

var res = LabtopRam.CreateLaptop();

Console.WriteLine(res.ToString());

Console.ReadKey();