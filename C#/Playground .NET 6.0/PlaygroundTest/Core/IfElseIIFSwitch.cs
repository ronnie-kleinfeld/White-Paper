using PlaygroundTest.Core.Var;

namespace PlaygroundTest.Core
{
    [TestClass]
    public class IfElseIIFSwitch
    {
        [TestMethod]
        public void Testif()
        {
            Assert.AreEqual(1, DoIf(1));
            Assert.AreEqual(2, DoIf(2));
            Assert.AreEqual(-1, DoIf(3));
        }
        public int DoIf(int input)
        {
            if (input == 1)
            {
                return 1;
            }
            else if (input == 2)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }

        [TestMethod]
        public void TestIIf()
        {
            Assert.AreEqual(true, DoIIf(1));
            Assert.AreEqual(false, DoIIf(2));
        }
        public bool DoIIf(int input)
        {
            return input == 1 ? true : false;
        }

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
                case (>= 'a' and <= 'z') or (>= 'A' and <= 'Z'):
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
    }

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