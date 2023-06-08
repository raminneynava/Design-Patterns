using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Notification
{
    public class GmailAdapter : ISendMessage
    {

        GmailService GmailService=new GmailService();


        public void Send(string Text)
        {
            GmailService.SendMail(Text);
        }
    }
}
