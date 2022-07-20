using System.Timers;
namespace EventsDemo
{
    public abstract class MessageServiceBase : IMessagingService
    {
        private readonly System.Timers.Timer messagesTimer;
		private readonly Random random;
        public string ServiceName { get; protected set; }

		public event MessageReceivedEventHandler MessageReceived;

        public void Dispose()
		{
			messagesTimer.Elapsed -= this.MessagesTimer_Elapsed;
			messagesTimer.Stop();
			messagesTimer.Dispose();
		}

        public abstract void SendMessage(string message);

        private void MessagesTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
            MessageReceived?.Invoke(this, new MessageReceivedEventArgs($"Mensaje recibido desde {ServiceName}"));
            messagesTimer.Interval = random.Next(2000,5001);
		}

		public MessageServiceBase()
		{
			random = new Random(DateTime.Now.Millisecond);
			messagesTimer = new System.Timers.Timer { Interval = random.Next(2000, 5001) };
			messagesTimer.Elapsed += MessagesTimer_Elapsed;
			messagesTimer.Start();
		}
    }
}