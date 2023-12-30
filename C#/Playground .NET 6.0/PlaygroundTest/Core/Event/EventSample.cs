namespace CoreConsoleApp.Core.Event
{
    internal class EventSample
    {
        //public static void Main()
        //{
        //    SampleDataUseage();
        //}

        public static void EventUsage()
        {
            var myData = new ScoreData();
            myData.ScoreChanged += MyData_ScoreChanged;
            myData.Score = 5;
            myData.Score = 7;
            myData.Score = 123;
        }

        public static void InlineEvent()
        {
            var myData = new ScoreData();
            myData.ScoreChanged += (sender, e) =>
            {
                Console.WriteLine("Score changed to " + e.Score);
            };
            myData.Score = 5;
            myData.Score = 7;
            myData.Score = 123;
        }

        private static void MyData_ScoreChanged(object? sender, ScoreChangedEventArgs e)
        {
            Console.WriteLine("Score changed to " + e.Score);
        }
    }
}