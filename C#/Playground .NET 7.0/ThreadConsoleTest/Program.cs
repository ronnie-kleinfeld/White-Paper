using ThreadConsoleTest.Threads;

namespace ThreadConsoleTest
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //FunctionInThreadSample.Usage();
            //FunctionAsAsyncSample.Usage();
            //ThreadConsoleTest.BreakfastSync.Cook(args);
            //await ThreadConsoleTest.BreakfastAsync.Cook(args);
            //await TAPSample.Samples();
            //ProgressOfAsyncProcess.ProgressSample();
            //FunctionInThread.Start();
            //Lock.Sample();
            //ThreadSendAndCallback.Start();
            //TaskChaining.Sample();
            MutexLock.Start();
        }
    }
}