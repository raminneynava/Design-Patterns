using Decorator;

concreatComponent obj = new concreatComponent();

ConcreateDecorator condec = new ConcreateDecorator(obj);
ConcreateDecorator2 condec2 = new ConcreateDecorator2(obj);

condec.Operation();
condec2.Operation();

Console.ReadKey();
