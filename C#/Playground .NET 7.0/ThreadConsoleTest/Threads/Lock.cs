namespace ThreadConsoleTest.Threads
{
    public class Lock
    {
        private static bool isCompleted;
        static readonly object lockCompleted = new object();

        public static void Sample()
        {
            ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);

            Thread thread = new Thread(HelloWorld);
            thread.Start();

            HelloWorld();

            ConsoleWriterHelper.WriteFinish();
            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);

            ConsoleWriterHelper.WriteLine("pre lock");
            lock (lockCompleted)
            {
                ConsoleWriterHelper.WriteLine("in lock 1");
                ConsoleWriterHelper.WriteLine(isCompleted.ToString());
                if (isCompleted)
                {
                    ConsoleWriterHelper.WriteLine("Completed");
                }
                else
                {
                    isCompleted = true;
                    ConsoleWriterHelper.WriteLine("MESSAGE 1");
                }
                ConsoleWriterHelper.WriteLine("in lock 2");
            }
            ConsoleWriterHelper.WriteLine("post lock");
        }

        private static void LockVsMonitor()
        {
            var lockObject = new Object();

            lock (lockObject)
            {
                // action to lock
            }

            Monitor.Enter(lockObject);
            try
            {
                // action to lock
            }
            finally
            {
                Monitor.Exit(lockObject);
            }
        }
    }
}