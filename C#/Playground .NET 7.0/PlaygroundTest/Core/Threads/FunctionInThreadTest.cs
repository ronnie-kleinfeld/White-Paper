namespace PlaygroundTest.Core.Threads
{
    [TestClass]
    public class FunctionInThreadTest
    {
        [TestMethod]
        public void FunctionInThread()
        {
            Console.WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}");

            Thread t = new Thread(DoWork);

            t.Start();
            Console.WriteLine("Work happening in main thread.");
            t.Join();
            Console.WriteLine("After all done");

            Assert.AreEqual(0, 0);
        }

        public static void DoWork()
        {
            Console.WriteLine($"Other thread id: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Work happeing in other thread.");
        }
    }
}