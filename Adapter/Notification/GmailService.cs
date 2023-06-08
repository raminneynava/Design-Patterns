namespace Adapter.Notification
{
    public class GmailService
    {
        public void SendMail(string Text)
        {
            Console.WriteLine("send by GmailService:" + Text);
        }
    }
}
