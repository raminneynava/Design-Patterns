using System;

using Bridge2.MailService;

namespace Bridge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MailServiceAbstraction abstraction = new RefindeMailService();

            abstraction.Send(new EmailInftoDto{
                Message="Hello",
                Reciver="info@mail.com",
                Title="Email"
            });
        }
    }
}
