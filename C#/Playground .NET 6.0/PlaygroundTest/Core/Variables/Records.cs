using System.Drawing;

namespace CoreConsoleApp.Core.Variables
{
    public class Test
    {
        public Test()
        {
            var myCards = new CardsRecord("Heart", "Ace");
            Console.WriteLine(myCards.Rank);

            // record deconstruction into tuple
            var rect = new Rectangle(new Point(75, 25), new Point(90, 95));
            (int height, int width) = rect; // use the automatic or custom Deconstruct method
        }
    }

    public record class CardsRecord(string Suit, string Rank);

    internal record Rectangle
    {
        Point _topLeft;
        Point _bottomRight;

        public int Length { get { return _bottomRight.X - _topLeft.X; } }
        public int Height { get { return _bottomRight.Y - _topLeft.Y; } }

        internal Rectangle(Point topLeft, Point bottomRight)
        {
            _topLeft = topLeft;
            _bottomRight = bottomRight;
        }

        internal int CalculateArea()
        {
            return Length * Height;
        }

        public void Deconstruct(out int l, out int h)
        {
            l = Length; h = Height;
        }

        public override string ToString()
        {
            return $"[{_topLeft.X},{_topLeft.Y}] - {_bottomRight.X},{_bottomRight.Y}]";
        }
    }
}
