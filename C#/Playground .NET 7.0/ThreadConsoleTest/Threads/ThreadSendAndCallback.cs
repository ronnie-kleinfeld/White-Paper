namespace ThreadConsoleTest.Threads
{
    public class ThreadSendAndCallback
    {
        public static void Start()
        {
            ConsoleWriterHelper.WriteLine("ThreadSendAndCallback 1");
            ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);

            WorkerWithState tws = new WorkerWithState("Ronnie", 42, new ExampleCallback(ResultCallback)
            );

            Thread t = new Thread(new ThreadStart(tws.ThreadProc));
            t.Start();
            ConsoleWriterHelper.WriteLine("Main thread ");
            t.Join();
            ConsoleWriterHelper.WriteLine("main thread ends.");

            ConsoleWriterHelper.WriteFinish();
        }

        public static void ResultCallback(int lineCount)
        {
            ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleWriterHelper.WriteLine("Lines=" + lineCount);
        }
    }

    public delegate void ExampleCallback(int lineCount);

    public class WorkerWithState
    {
        private string name;
        private int id;

        private ExampleCallback callback;

        public WorkerWithState(string text, int number,
            ExampleCallback callbackDelegate)
        {
            ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            name = text;
            id = number;
            callback = callbackDelegate;
        }

        public void ThreadProc()
        {
            ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleWriterHelper.WriteLine(name + id);
            if (callback != null)
            {
                ConsoleWriterHelper.WriteLine("ThreadProc");
                callback(15);
            }
        }
    }
}