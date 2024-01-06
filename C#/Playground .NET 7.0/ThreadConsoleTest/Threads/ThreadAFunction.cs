namespace ThreadConsoleTest.Threads
{
    internal class ThreadAFunction
    {
        public static void Start()
        {
            ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);

            Thread thread = new Thread(WriteUsingNewThread);
            thread.Name = "Cazton Worker";
            thread.Start();

            Thread.CurrentThread.Name = "Cazton main";
            for (int i = 100; i < 110; i++)
            {
                ConsoleWriterHelper.WriteLine(" A" + i + " ");
            }

            ConsoleWriterHelper.WriteFinish();
            Console.ReadKey();
        }

        private static void WriteUsingNewThread()
        {
            ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            for (int i = 200; i < 210; i++)
            {
                ConsoleWriterHelper.WriteLine(" Z" + i + " ");
            }
        }
    }
}