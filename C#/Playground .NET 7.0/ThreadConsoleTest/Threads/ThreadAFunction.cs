namespace ThreadConsoleTest.Threads
{
    internal class ThreadAFunction
    {
        public static void Start()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);

            Thread thread = new Thread(WriteUsingNewThread);
            thread.Name = "Cazton Worker";
            thread.Start();

            Thread.CurrentThread.Name = "Cazton main";
            for (int i = 100; i < 110; i++)
            {
                ConsoleHelper.WriteLine(" A" + i + " ");
            }

            Console.ReadKey();
        }

        private static void WriteUsingNewThread()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            for (int i = 200; i < 210; i++)
            {
                ConsoleHelper.WriteLine(" Z" + i + " ");
            }
        }
    }
}