namespace DependencyInjection.Sender
{
    public class SMSSender : ISender
    {
        void ISender.SendMessage(string message)
        {
            Console.WriteLine("send message via SMS");
        }
    }
}
