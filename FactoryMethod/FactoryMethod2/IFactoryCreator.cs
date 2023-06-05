using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    public interface IFactoryCreator
    {
        IEmailManager SendEmail();
    }

    public class GoogleEmailSend : IFactoryCreator
    {
        public IEmailManager SendEmail()
        {
            return new Google();
        }
    }
    public class YahooEmailSend : IFactoryCreator
    {
        public IEmailManager SendEmail()
        {
            return new Yahoo();
        }
    }
    public class HotmailEmailSend : IFactoryCreator
    {
        public IEmailManager SendEmail()
        {
            return new Hotmail();
        }
    }
}
