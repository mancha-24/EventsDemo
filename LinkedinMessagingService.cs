// See https://aka.ms/new-console-template for more information
using EventsDemo;

internal class LinkedinMessagingService: MessageServiceBase
{
    public LinkedinMessagingService() : base()
    {
        ServiceName = "Linkedin";
    }

    public override void SendMessage(string message)
    {
        Console.WriteLine($"Mensaje enviado por Linkedin: {message}");
    }
}