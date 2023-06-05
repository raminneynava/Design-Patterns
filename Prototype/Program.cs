// See https://aka.ms/new-console-template for more information
using Prototype;

Console.WriteLine("Hello, World!");

var largeobject=new LargeObject();

largeobject.title = "title";
largeobject.Id = "id";
largeobject.InerClass = new InerClass
{
    Text = "text"
};

var shallow= largeobject.ShallowCopy();
shallow.title= "shallowtitle";

var deep= largeobject.DeepCopy();
deep.title = "deeptitle";

Console.WriteLine(largeobject.title);
Console.WriteLine(shallow.title);
Console.WriteLine(deep.title);
Console.ReadKey();