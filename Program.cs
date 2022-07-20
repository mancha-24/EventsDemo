// See https://aka.ms/new-console-template for more information
using EventsDemo;

Console.WriteLine("Hello, World!");

var twitterMessagingService = new TwitterMessagingService();
var facebookMessagingService = new FacebookMessagingService();
var linkedinMessagingService = new LinkedinMessagingService();

//twitterMessagingService.MessageReceived += (sender, e) => Console.WriteLine(e.Message);
twitterMessagingService.MessageReceived += MessagingService_MessageReceived;
facebookMessagingService.MessageReceived += MessagingService_MessageReceived;
linkedinMessagingService.MessageReceived += MessagingService_MessageReceived;
Console.ReadLine();
twitterMessagingService.MessageReceived -= MessagingService_MessageReceived;
facebookMessagingService.MessageReceived -= MessagingService_MessageReceived;
linkedinMessagingService.MessageReceived -= MessagingService_MessageReceived;
twitterMessagingService.Dispose();
facebookMessagingService.Dispose();
linkedinMessagingService.Dispose();

Console.ReadLine();

static void MessagingService_MessageReceived(object sender, MessageReceivedEventArgs e)
{
    Console.WriteLine(e.Message);
}
