// See https://aka.ms/new-console-template for more information




ConcreateColleague1 c1 = new ConcreateColleague1();
ConcreateColleague2 c2 = new ConcreateColleague2();

ConcreateMediator mediator = new ConcreateMediator(c1, c2);


c1.SetMediator(mediator);
c2.SetMediator(mediator);


c1.Send("salam");
c2.Send("khoobi?");



Console.ReadKey();
