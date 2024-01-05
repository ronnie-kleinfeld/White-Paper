namespace ThreadConsoleTest.Threads
{
    public class SemaphoreSlimLock
    {
        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3);
        public static void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                new Thread(EnterSemaphore).Start(i + 1);
            }
        }

        private static void EnterSemaphore(object id)
        {
            Console.WriteLine(id + " is waiting to be part of the club");
            semaphoreSlim.Wait();
            Console.WriteLine(id + " part of the club");
            Thread.Sleep(1000 / (int)id);
            Console.WriteLine(id + " left the club");
        }
    }
}