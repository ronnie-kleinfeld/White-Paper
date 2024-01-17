namespace ThreadConsoleTest.Synchronization
{
    public class LockSample
    {
        private static void LockVsMonitor()
        {
            var lockObject = new object();

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

        private static bool isCompleted;
        static readonly object lockCompleted = new object();

        public static void Start()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);

            Thread thread = new Thread(HelloWorld);
            thread.Start();

            HelloWorld();

            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);

            ConsoleHelper.WriteLine("pre lock");
            lock (lockCompleted)
            {
                ConsoleHelper.WriteLine("in lock 1");
                ConsoleHelper.WriteLine(isCompleted.ToString());
                if (isCompleted)
                {
                    ConsoleHelper.WriteLine("Completed");
                }
                else
                {
                    isCompleted = true;
                    ConsoleHelper.WriteLine("MESSAGE 1");
                }
                ConsoleHelper.WriteLine("in lock 2");
            }
            ConsoleHelper.WriteLine("post lock");
        }
    }
}