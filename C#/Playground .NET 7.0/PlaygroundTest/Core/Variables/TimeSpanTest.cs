using System.Globalization;

namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class TimeSpanTest
    {
        [TestMethod]
        public void Init()
        {
            var timespan1 = new TimeSpan(1, 2, 3);
            var timespan2 = TimeSpan.FromHours(1);
            var timespan3 = DateTime.Now.AddMinutes(2) - DateTime.Now;

            Console.WriteLine(timespan1);
            Console.WriteLine(timespan2);
            Console.WriteLine(timespan3);

            Console.WriteLine(timespan1.Minutes);
            Console.WriteLine(timespan1.TotalMinutes);

        }
    }
}
