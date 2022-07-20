// See https://aka.ms/new-console-template for more information
using EventsDemo;

internal class FacebookMessagingService : MessageServiceBase
{
    public FacebookMessagingService() :base()
    {
        ServiceName = "Facebook";
    }

    public override void SendMessage(string message)
    {
        Console.WriteLine($"Mensaje enviado por Facebook: {message}");
    }
}