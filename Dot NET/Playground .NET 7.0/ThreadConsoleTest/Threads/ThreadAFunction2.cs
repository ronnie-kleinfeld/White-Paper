namespace ThreadConsoleTest.Threads
{
    public class ThreadAFunction2
    {
        public static void Start()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("Begin");
            Thread t1 = new Thread(DoWork1);

            ConsoleHelper.WriteLine("Start");
            t1.Start();

            ConsoleHelper.WriteLine("Work");

            Thread t2 = new Thread(DoWork2);
            ConsoleHelper.WriteLine("Start");
            t2.Start();

            ConsoleHelper.WriteLine("Work");

            ConsoleHelper.WriteLine("Join");
            t2.Join();
            ConsoleHelper.WriteLine("Joined");

            ConsoleHelper.WriteLine("Join");
            t1.Join();
            ConsoleHelper.WriteLine("Joined");

            ConsoleHelper.WriteLine("Finished");
        }

        public static void DoWork1()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("Work");
            Thread.Sleep(3000);
            ConsoleHelper.WriteLine("Work");
        }
        public static void DoWork2()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("Work");
            Thread.Sleep(1000);
            ConsoleHelper.WriteLine("Work");
        }
    }
}