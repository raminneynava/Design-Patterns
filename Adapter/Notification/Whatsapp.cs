namespace Adapter.Notification
{
    public class Whatsapp : ISendMessage
    {
        public void Send(string Text)
        {
            Console.WriteLine("send by Whatsapp:" + Text);
        }
    }
}
