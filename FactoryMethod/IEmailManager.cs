using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IEmailManager
    {
        void Send(EmailDto dto);
        List<EmailDto> GetAll();
    }

    public class EmailDto
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Message { get; set; }
    }
}
