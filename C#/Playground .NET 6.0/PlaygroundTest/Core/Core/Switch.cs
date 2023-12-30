namespace PlaygroundTest.Core.Core
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void TestSwitch()
        {
            Assert.AreEqual(1, DoSwitch(1));
            Assert.AreEqual(23, DoSwitch(2));
            Assert.AreEqual(23, DoSwitch(3));
            Assert.AreEqual(-1, DoSwitch(4));
        }
        public int DoSwitch(int input)
        {
            int result;

            switch (input)
            {
                case 1:
                    result = 1;
                    break;
                case 2:
                case 3:
                    result = 23;
                    break;
                default:
                    result = -1;
                    break;
            }

            return result;
        }

        public void InlineSwitch()
        {
            var shiftDay = GetShiftDays((DayOfWeek)17);
            Console.WriteLine(shiftDay);

            static ShiftDays GetShiftDays(DayOfWeek day) => day switch
            {
                DayOfWeek.Monday => ShiftDays.Monday,
                DayOfWeek.Tuesday => ShiftDays.Tuesday,
                DayOfWeek.Wednesday => ShiftDays.Wednesday,
                DayOfWeek.Thursday => ShiftDays.Thursday,
                DayOfWeek.Friday => ShiftDays.Friday,
                DayOfWeek.Saturday => ShiftDays.Saturday,
                DayOfWeek.Sunday => ShiftDays.Sunday,
                _ => throw new ArgumentException("Invalid day of week suppliied")

            };
        }
        public void InlineSwitchOnType(IPerson p)
        {
            var result = p switch
            {
                ShiftWorker swv => $"{swv.FirstName} {swv.LastName}: {swv.StartDate}",
                Manager mgr => $"{mgr.FirstName} {mgr.LastName} Reports: {mgr.NumberOfDirectReports}",
                _ => string.Empty
            };
        }
        public string InlineSwitchRelations()
        {
            char padChar = 'a';
            switch (padChar)
            {
                case >= 'a' and <= 'z' or >= 'A' and <= 'Z':
                    return "alpha";
                case >= '0' and <= '9':
                    return "digit";
                default:
                    return "other";
            }
        }

        public bool InlineSwitchWithDeepValueProperties(DateTime shiftDate) => shiftDate switch
        {
            { Hour: >= 15, DayOfWeek: DayOfWeek.Friday or DayOfWeek.Saturday } => true,
            _ => false
        };
        public string InlineSwitchWithWhenCondition(IPerson p)
        {
            var result = p switch
            {
                ShiftWorker swv when swv.StartDate.Year > 2020 => $"{swv.FirstName} {swv.LastName}: {swv.StartDate}",
                ShiftWorker swv when swv.StartDate.Year <= 2020 => $"Older employee",
                Manager mgr => $"{mgr.FirstName} {mgr.LastName} Reports: {mgr.NumberOfDirectReports}",
                _ => string.Empty
            };

            return result;
        }
        public decimal MulitpleSwitchPattern(int groupSize, DateTime visitDate)
            => (groupSize, visitDate.DayOfWeek) switch
            {
                ( <= 0, _) => throw new ArgumentException("Group size must be a positive number"),
                (_, DayOfWeek.Saturday or DayOfWeek.Sunday) => 0.0m,
                ( >= 5 and < 10, DayOfWeek.Monday) => 0.2m,
                ( >= 10, DayOfWeek.Monday) => 0.3m,
                ( >= 5 and < 10, _) => 0.12m,
                ( >= 10, _) => 0.15m,
                _ => 0.0m,
            };

        [Flags]
        public enum ShiftDays : short
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 4,
            Wednesday = 8,
            Thursday = 16,
            Friday = 32,
            Weekdays = 63,
            Saturday = 64,
            Weekend = 65
        }
        public interface IPerson
        {
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
        }
        public abstract class Employee : IPerson
        {
            //IPerson
            public string? LastName { get; set; }
            public string? FirstName { get; set; }

            public DateOnly StartDate { get; set; }
        }
        public class ShiftWorker : Employee
        {
            public ShiftDays DaysAvailable { get; set; }
            public TimeOnly ShiftStartTime { get; set; }
        }
        public class Manager : Employee, IPerson
        {
            public int NumberOfDirectReports { get; set; }
        }
    }
}