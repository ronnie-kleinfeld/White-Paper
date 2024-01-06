namespace ThreadConsoleTest.Threads
{
    public class ThreadSendDataCallback
    {
        public static void Start()
        {
            var tsdc = new ThreadSendDataCallback();
            tsdc.Test();
        }

        private string message;

        public void Test()
        {
            ConsoleHelper.WriteLine("ThreadSendDataAndCallback 1");
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);

            WorkerWithState tws = new WorkerWithState("Ask", new WorkerWithState.WorkerCallback(ResultCallback)
            );

            Thread t = new Thread(new ThreadStart(tws.ThreadProc));
            t.Start();
            ConsoleHelper.WriteLine("Main thread ");
            t.Join();
            ConsoleHelper.WriteLine(this.message);
            ConsoleHelper.WriteLine("ThreadSendDataAndCallback 2");
        }

        public string ResultCallback(string message)
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine(message);
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
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine(message);
            this.message = message;
            this.callback = callbackDelegate;
        }

        public void ThreadProc()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine(message);
            if (callback != null)
            {
                ConsoleHelper.WriteLine("Call callback");
                string str = callback("123456");
                ConsoleHelper.WriteLine(str);
            }
        }
    }
}