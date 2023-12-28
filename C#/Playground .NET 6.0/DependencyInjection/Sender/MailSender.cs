namespace DependencyInjection.Sender
{
    public class MailSender : ISender
    {
        void ISender.SendMessage(string message)
        {
            Console.WriteLine("send message via EMAIL");
        }
    }
}
