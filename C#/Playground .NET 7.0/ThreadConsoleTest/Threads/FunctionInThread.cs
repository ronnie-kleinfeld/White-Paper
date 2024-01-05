namespace ThreadConsoleTest.Threads
{
    internal class FunctionInThread
    {
        public static void Start()
        {
            ConsoleWriterHelper.Write(Thread.CurrentThread.ManagedThreadId);

            Thread thread = new Thread(WriteUsingNewThread);
            thread.Name = "Cazton Worker";
            thread.Start();

            Thread.CurrentThread.Name = "Cazton main";
            for (int i = 100; i < 110; i++)
            {
                ConsoleWriterHelper.Write(" A" + i + " ");
            }

            ConsoleWriterHelper.WriteFinish();
            Console.ReadLine();
        }

        private static void WriteUsingNewThread()
        {
            ConsoleWriterHelper.Write(Thread.CurrentThread.ManagedThreadId);
            for (int i = 200; i < 210; i++)
            {
                ConsoleWriterHelper.Write(" Z" + i + " ");
            }
        }
    }
}