using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2.MailService
{
    public interface IMailServiceImplementor
    {
        void SendEmail(string Reciver,string Title,string Message);
    }

    public class GmailService : IMailServiceImplementor
    {
        public void SendEmail(string Reciver, string Title, string Message)
        {
            Console.WriteLine("Send By Google");
            Console.WriteLine(Title);
            Console.WriteLine(Reciver);
            Console.WriteLine(Message);
        }
    }
    public class YahooService : IMailServiceImplementor
    {
        public void SendEmail(string Reciver, string Title, string Message)
        {
            Console.WriteLine("Send By Yahoo");
            Console.WriteLine(Title);
            Console.WriteLine(Reciver);
            Console.WriteLine(Message);
        }
    }
}
