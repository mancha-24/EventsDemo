// See https://aka.ms/new-console-template for more information
using EventsDemo;

internal class TwitterMessagingService : MessageServiceBase
{
    public TwitterMessagingService() : base()
    {
        ServiceName = "Twitter";
    }

    public override void SendMessage(string message)
    {
        Console.WriteLine($"Mensaje enviado por Twitter: {message}");
    }
}