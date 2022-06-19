using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2.MailService
{
    public static class Implementation
    {
        public static IMailServiceImplementor GetImplementor()
        {
            string serv = "gmail";
            if (serv == "gmail")
            {
                return new GmailService();
            }
            else
            {
                return new YahooService();
            }

        }

    }
}
