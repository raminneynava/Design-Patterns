// See https://aka.ms/new-console-template for more information



using Adapter.ClassAdapter;
using Adapter.Notification;

//*************************
//object adapter

Target trget = new Apapter();
trget.Operation();
/////////////////////////////////////////////////


//*************************
//class adapter

ITarget Classtrget = new AdapterClass();

Classtrget.Operation();

////////////////////////////////////////////////



ISendMessage SendMessageTelegram = new Telegram();
SendMessageTelegram.Send("Test By Telegram");

ISendMessage SendMessageWhatsapp = new Whatsapp();
SendMessageWhatsapp.Send("Test By Whatsapp");


ISendMessage SendMessageGmail=new GmailAdapter();
SendMessageGmail.Send("Test By GmailAdapter");

////////////////////////////////////////////////

Console.ReadKey();

