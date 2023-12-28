using System.Drawing;

namespace PlaygroundTest.Core.Linq
{
    public class LinqS
    {
        public static void Test()
        {
            var points = new List<Point>();

            points.Count(x => x.X > 100);

            points.Where(x => x.X > 100);
            points.OrderBy(x => x.Y);

            points.Single(x => x.X > 100);
            points.SingleOrDefault(x => x.X > 100);

            points.First(x => x.X > 100);
            points.FirstOrDefault(x => x.X > 100);

            points.Last(x => x.X > 100);
            points.LastOrDefault(x => x.X > 100);

            points.Min(x => x.X > 100);
            points.Max(x => x.X > 100);

            points.Sum(x => x.X);
            points.Average(x => x.X);

            points.Skip(50).Take(10);
        }
    }
}