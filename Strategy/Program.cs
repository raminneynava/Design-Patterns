// See https://aka.ms/new-console-template for more information


using Strategy;
using Strategy.Sort;

Context context;

context = new Context(new ConcreateStrategyA());

context.ContextInterface();


context = new Context(new ConcreateStrategyB());
context.ContextInterface();

context = new Context(new ConcreateStrategyC());
context.ContextInterface();

var users = new User[]
{
   new User { Id=1,Name="name0",LastName="last3",Creadit=25000},
   new User { Id=3,Name="name4",LastName="last2",Creadit=35000},
   new User { Id=4,Name="name5",LastName="last1",Creadit=45000},
   new User { Id=2,Name="name1",LastName="last0",Creadit=15000}
};
Console.WriteLine("---------------------- Befor Sort ----------------------");
foreach (var user in users)
{
    user.Display();
}

Array.Sort(users,new UserCreadit_Comparer());

Console.WriteLine("---------------------- After Creadit Sort ----------------------");
foreach (var user in users)
{
    user.Display();
}

Array.Sort(users, new UserById_Comparer());

Console.WriteLine("---------------------- After Id Sort ----------------------");
foreach (var user in users)
{
    user.Display();
}
