namespace ThreadConsoleTest.Threads
{
    public class ThreadSendDataCallback
    {
        public static void Main()
        {
            var tsdc = new ThreadSendDataCallback();
            tsdc.Start();
        }

        private string message;

        public void Start()
        {
            ConsoleWriterHelper.WriteLine("ThreadSendDataAndCallback 1");
            ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);

            WorkerWithState tws = new WorkerWithState("Ask", new WorkerWithState.WorkerCallback(ResultCallback)
            );

            Thread t = new Thread(new ThreadStart(tws.ThreadProc));
            t.Start();
            ConsoleWriterHelper.WriteLine("Main thread ");
            t.Join();
            ConsoleWriterHelper.WriteLine(this.message);
            ConsoleWriterHelper.WriteLine("ThreadSendDataAndCallback 2");

            ConsoleWriterHelper.WriteFinish();
        }

        public string ResultCallback(string message)
        {
            ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleWriterHelper.WriteLine(message);
            this.message = message;
            return message;
        }
    }

    public class WorkerWithState
    {
        public delegate string WorkerCallback(string message);

        private string message;

        private WorkerCallback callback;

        public WorkerWithState(string message, WorkerCallback callbackDelegate)
        {
            ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleWriterHelper.WriteLine(message);
            this.message = message;
            this.callback = callbackDelegate;
        }

        public void ThreadProc()
        {
            ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleWriterHelper.WriteLine(message);
            if (callback != null)
            {
                ConsoleWriterHelper.WriteLine("Call callback");
                string str = callback("123456");
                ConsoleWriterHelper.WriteLine(str);
            }
        }
    }
}