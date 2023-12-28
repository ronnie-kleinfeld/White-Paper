using System.ComponentModel;

namespace CoreConsoleApp.Core.Event
{
    public class ScoreData
    {
        public event EventHandler<ScoreChangedEventArgs> ScoreChanged;

        private int score = 0;
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;

                ScoreChanged(this, new ScoreChangedEventArgs(score));
            }
        }
    }
}