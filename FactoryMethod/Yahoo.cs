using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Yahoo : IEmailManager
    {
        public List<EmailDto> GetAll()
        {
            List<EmailDto> emails = new();
            return emails;
        }

        public void Send(EmailDto dto)
        {
            Console.WriteLine($"Message from {dto.From} to {dto.To} : {dto.Message}");
        }
    }
}
