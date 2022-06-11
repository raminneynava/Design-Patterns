


var obj1 = Singleton.Singleton.GeTinstance();
var obj2 = Singleton.Singleton.GeTinstance();

var obj3 = Singleton.SingletonLazy.GeTinstance();
var obj4 = Singleton.SingletonLazy.GeTinstance();


Console.WriteLine(obj1==obj2); //true
Console.WriteLine(obj3==obj4); //true

Console.WriteLine(obj3._name +"-"+ obj3._age); 
Console.WriteLine(obj4._name +"-"+ obj4._age); 

Console.ReadKey();