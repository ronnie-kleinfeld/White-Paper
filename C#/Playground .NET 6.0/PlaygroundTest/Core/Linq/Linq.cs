using System.Drawing;

namespace PlaygroundTest.Core.Linq
{
    public class Linq
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

        public static void DoLinq()
        {
            var list = new List<double> { 1.1, 3.3, 5.5 };
            var linq1 = list.Where(num => num > 3);

            Console.WriteLine(list.Count);
            Console.WriteLine(linq1.Count());
        }
    }
}