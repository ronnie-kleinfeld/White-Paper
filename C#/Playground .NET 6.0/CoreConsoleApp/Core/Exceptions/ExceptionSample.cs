namespace CoreConsoleApp.Core.Exceptions
{
    public class ExceptionSample
    {
        // public static void Main()
        // {
        //     try
        //     {
        //         DoSomething();

        //     }
        //     catch (CustomException ex)
        //     {
        //         Console.WriteLine("Exception " + ex.SomeData);
        //     }
        //     catch
        //     {

        //     }
        //     finally
        //     {
        //         // close connections..
        //     }
        // }

        private static void DoSomething()
        {
            throw new CustomException(8);
        }
    }
}