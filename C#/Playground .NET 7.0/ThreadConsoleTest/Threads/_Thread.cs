
namespace ThreadConsoleTest.Threads
{
    public class _Thread
    {
        public static void Init()
        {
            Thread thread = new Thread(() =>
            {
                ConsoleHelper.WriteLine("");
                Task.Delay(2000);
            });
            thread.Name = "Cazton Worker";
            thread.Start();
            thread.Join();
        }
    }
}