namespace ThreadConsoleTest.Threads
{
    public class _ThreadInlineAction
    {
        public static void Start()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread thread = new Thread(() =>
            {
                ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
                ConsoleHelper.WriteLine("Work");
                Task.Delay(2000);
                ConsoleHelper.WriteLine("Work");
            });
            thread.Name = "Cazton Worker";
            thread.Start();
            ConsoleHelper.WriteLine("Started");
            thread.Join();
            ConsoleHelper.WriteLine("Joined");

            Console.ReadKey();
        }
    }
}