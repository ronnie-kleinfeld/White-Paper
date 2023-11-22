using System.ComponentModel;

namespace CoreConsoleApp.Core.Event
{
    public class ScoreData
    {
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
        public event EventHandler<ScoreChangedEventArgs> ScoreChanged;
    }
}