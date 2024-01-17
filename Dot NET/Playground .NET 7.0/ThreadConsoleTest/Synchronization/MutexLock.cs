namespace ThreadConsoleTest.Threads
{
    public class MutexLock
    {
        static Mutex mutex = new Mutex();
        public static void Start()
        {
            for (int i = 0; i < 10; i++)
            {

                Thread thread = new Thread(AcquireMutex);
                thread.Name = string.Format("Thread{0}", i + 1);
                thread.Start();
            }

            Console.ReadKey();
        }

        private static void AcquireMutex()
        {
            mutex.WaitOne();
            DoSomething();
            mutex.ReleaseMutex();
            Console.WriteLine("Mutex released by {0}", Thread.CurrentThread.Name);
        }

        private static void DoSomething()
        {
            Console.WriteLine("Mutex acquired by {0}", Thread.CurrentThread.Name);
            Thread.Sleep(1500);
            Console.WriteLine("Mutex do something by {0}", Thread.CurrentThread.Name);
        }
    }
}