using DependencyInjection.Logger;

namespace DependencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var someProcess = new SomeProcess(new ConsoleLogger());
            someProcess.DoProcess();
        }
    }
}
