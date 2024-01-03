using System.Text.Json;

namespace PlaygroundTest.Core.Threads
{
    [TestClass]
    public class FunctionAsAsyncTest
    {
        [TestMethod]
        public void FunctionAsAsync()
        {
            Console.WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}");

            DoCall();
            Console.WriteLine("Work done");

            Assert.AreEqual(0, 0);
        }

        public static async void DoCall()
        {
            await DoFileWorkAsync();
        }

        public static async Task DoFileWorkAsync()
        {
            Console.WriteLine($"File access thread id: {Thread.CurrentThread.ManagedThreadId}");

            string filePath = "matt.json";
            foreach (String s in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                if (s.Contains(".json"))
                {
                    var employeeJson = await File.ReadAllTextAsync(s);
                    await Console.Out.WriteLineAsync(employeeJson);
                }
            }

            await Console.Out.WriteLineAsync("Read finished");
        }
    }
}