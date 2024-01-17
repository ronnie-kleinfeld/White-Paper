namespace PlaygroundTest.Core.Interfaces
{
    public struct Car : IDisposable
    {
        public FileStream FileStream { get; set; }

        public Car()
        {
            FileStream = new FileStream("path", FileMode.Append);
        }

        void IDisposable.Dispose()
        {
            FileStream.Flush();
            FileStream.Close();
            FileStream.Dispose();
        }
    }
}