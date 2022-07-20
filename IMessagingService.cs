namespace EventsDemo
{
    public interface IMessagingService
    {
        event MessageReceivedEventHandler MessageReceived;
		void SendMessage(string message);
    }
}