using System.Globalization;

namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class DateTimeTest
    {
        [TestMethod]
        public void Search()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            DateOnly dt = DateOnly.FromDateTime(DateTime.Now);
            TimeOnly tm = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(dt);
            Console.WriteLine(tm);

            Console.WriteLine(today.DayOfWeek);
            Console.WriteLine(today.DayOfYear);

            now = now.AddDays(5);
            now = now.AddHours(9);
            now = now.AddMonths(1);
            Console.WriteLine(now);

            DateTime AprilFools = new DateTime(now.Year, 4, 1);
            DateTime NewYears = new DateTime(now.Year, 1, 1);
            TimeSpan interval = AprilFools - NewYears;
            Console.WriteLine(interval);

            Console.WriteLine($"{NewYears < AprilFools}");
            Console.WriteLine($"{NewYears > AprilFools}");
        }

        [TestMethod]
        public void Parse()
        {
            string[] sampleDateTimes = {
                "January 1, 2025 9:30 AM",
                "1/1/2025",
                "Jan 1, 2025 7:30PM",
                "Jan 1, 25",
                "1/2025",
                "1/1 7PM",
                "Jan 1 '15",
            };

            foreach (string datestr in sampleDateTimes)
            {
                DateTime result;

                if (DateTime.TryParse(datestr, out result))
                {
                    Console.WriteLine($"{datestr,-25} gets parsed as: {result}");
                } else
                {
                    Console.WriteLine($"Could not parse '{datestr}'");
                }
            }
        }

        [TestMethod]
        public void Format()
        {
            // Define a date
            DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

            // 'd' Short date: mm/dd/yyyy (or dd/mm depending on locale)
            Console.WriteLine($"{AprFools:d}");
            // 'D' Full date: mm/dd/yyyy (or dd/mm depending on locale)
            Console.WriteLine($"{AprFools:D}");

            // 'f' Full date, short time
            Console.WriteLine($"{AprFools:f}");
            // 'F' Full date, long time
            Console.WriteLine($"{AprFools:F}");

            // 'g' General date and time
            Console.WriteLine($"{AprFools:g}");
            // 'G' General date and time
            Console.WriteLine($"{AprFools:G}");

            // Format using a specific CultureInfo
            Console.WriteLine(AprFools.ToString("d", CultureInfo.CreateSpecificCulture("de-DE")));

            // Defining custom date and time formats
            Console.WriteLine($"{AprFools:dddd, MMMM d yyyy}");
            Console.WriteLine($"{AprFools:ddd h:mm:ss tt}");
            Console.WriteLine($"{AprFools:MMM d yyyy}");
        }
    }
}
