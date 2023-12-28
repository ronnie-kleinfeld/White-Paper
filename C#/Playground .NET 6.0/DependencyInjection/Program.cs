using DependencyInjection.Logger;
using DependencyInjection.Sender;

namespace DependencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            Console.WriteLine("Log to console and send to email");
            var someProcess1 = new SomeProcess(new ConsoleLogger(), new MailSender());
            someProcess1.DoProcess();

            Console.WriteLine();
            Console.WriteLine("Log to file and send to sms");
            var someProcess2 = new SomeProcess(new FileLogger(), new SMSSender());
            someProcess2.DoProcess();
        }
    }
}
