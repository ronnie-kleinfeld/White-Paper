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
            await TAPSample.Process();
        }
    }
}