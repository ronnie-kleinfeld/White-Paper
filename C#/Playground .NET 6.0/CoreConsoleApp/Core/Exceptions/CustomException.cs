namespace CoreConsoleApp.Core.Exceptions
{
    internal class CustomException : Exception
    {
        public int SomeData { get; set; }

        public CustomException(int someData)
        {
            SomeData = someData;
        }
    }
}