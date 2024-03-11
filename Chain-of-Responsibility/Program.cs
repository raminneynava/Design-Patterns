using Chain_of_Responsibility;

CreateOrder createOrder = new CreateOrder();
SendToDriver sendToDriver = new SendToDriver();
CheckActiveUser checkActiveUser = new CheckActiveUser();


checkActiveUser
    .SetSuccessor(createOrder)
    .SetSuccessor(sendToDriver);


checkActiveUser.Execute(new RequestContext
{
    Destination = new Point { Lat = 12.345, Lng = 15.252 },
    Origin = new Point { Lat = 19.356, Lng = 17.252 },
    UserId = 1
});

Console.ReadKey();