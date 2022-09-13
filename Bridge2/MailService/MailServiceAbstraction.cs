using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2.MailService
{
    public abstract class MailServiceAbstraction
    {
        private readonly IMailServiceImplementor _implementor;


        public MailServiceAbstraction()
        {
            _implementor = Implementation.GetImplementor();

        }
        public virtual void Send(EmailInftoDto emailInfto)
        {
            _implementor.SendEmail(emailInfto.Reciver, emailInfto.Title, emailInfto.Message);

        }
    }

    public class EmailInftoDto
    {
        public string Reciver { get; set; }
        public string Message { get; set; }
        public string Title { get; set; }
    }
}
