namespace DependencyInjection
{
    public class FileLogger : ILogger
    {
        void ILogger.Log(string message)
        {
            Console.WriteLine("Logging this to the file");
        }
    }
}
