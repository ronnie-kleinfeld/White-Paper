namespace ThreadConsoleTest.Threads
{
    public class FunctionInThreadSample
    {
        public static void Usage()
        {
            ConsoleWriterHelper.Write($"tid={Thread.CurrentThread.ManagedThreadId}");
            ConsoleWriterHelper.Write("Begin");
            Thread t1 = new Thread(DoWork1);

            ConsoleWriterHelper.Write("Start");
            t1.Start();

            ConsoleWriterHelper.Write("Work");

            Thread t2 = new Thread(DoWork2);
            ConsoleWriterHelper.Write("Start");
            t2.Start();

            ConsoleWriterHelper.Write("Work");

            ConsoleWriterHelper.Write("Join");
            t1.Join();
            ConsoleWriterHelper.Write("Joined");

            ConsoleWriterHelper.Write("Join");
            t2.Join();
            ConsoleWriterHelper.Write("Joined");

            ConsoleWriterHelper.Write("Finished");
            ConsoleWriterHelper.WriteFinish();
        }

        public static void DoWork1()
        {
            ConsoleWriterHelper.Write($"tid={Thread.CurrentThread.ManagedThreadId}");
            ConsoleWriterHelper.Write("Work");
        }
        public static void DoWork2()
        {
            ConsoleWriterHelper.Write($"tid={Thread.CurrentThread.ManagedThreadId}");
            ConsoleWriterHelper.Write("Work");
        }
    }
}