namespace ThreadConsoleTest.Threads
{
    public class FunctionInThreadSample
    {
        public static void Start()
        {
            ConsoleWriterHelper.WriteLine($"tid={Thread.CurrentThread.ManagedThreadId}");
            ConsoleWriterHelper.WriteLine("Begin");
            Thread t1 = new Thread(DoWork1);

            ConsoleWriterHelper.WriteLine("Start");
            t1.Start();

            ConsoleWriterHelper.WriteLine("Work");

            Thread t2 = new Thread(DoWork2);
            ConsoleWriterHelper.WriteLine("Start");
            t2.Start();

            ConsoleWriterHelper.WriteLine("Work");

            ConsoleWriterHelper.WriteLine("Join");
            t1.Join();
            ConsoleWriterHelper.WriteLine("Joined");

            ConsoleWriterHelper.WriteLine("Join");
            t2.Join();
            ConsoleWriterHelper.WriteLine("Joined");

            ConsoleWriterHelper.WriteLine("Finished");
            ConsoleWriterHelper.WriteFinish();
        }

        public static void DoWork1()
        {
            ConsoleWriterHelper.WriteLine($"tid={Thread.CurrentThread.ManagedThreadId}");
            ConsoleWriterHelper.WriteLine("Work");
        }
        public static void DoWork2()
        {
            ConsoleWriterHelper.WriteLine($"tid={Thread.CurrentThread.ManagedThreadId}");
            ConsoleWriterHelper.WriteLine("Work");
        }
    }
}