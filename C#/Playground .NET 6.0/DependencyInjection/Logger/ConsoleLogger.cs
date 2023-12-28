namespace DependencyInjection.Logger
{
    public class ConsoleLogger : ILogger
    {
        void ILogger.Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
