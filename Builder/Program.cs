// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");


Directore directore = new();

var builder1 = new ConcreateBuilder1();
var builder2 = new ConcreateBuilder2();

directore.SetBuilder(builder1);
directore.Construct();

var product1 = builder1.GetResult();
product1.Display();