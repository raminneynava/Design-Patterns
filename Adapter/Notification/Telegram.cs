namespace Adapter.Notification
{
    public class Telegram : ISendMessage
    {
        public void Send(string Text)
        {
            Console.WriteLine("send by Telegram:" + Text);
        }
    }
}
