namespace CoreConsoleApp.Core.Event
{
    public class ScoreChangedEventArgs : EventArgs
    {
        public int Score { get; set; }

        public ScoreChangedEventArgs(int score)
        {
            Score = score;
        }
    }
}