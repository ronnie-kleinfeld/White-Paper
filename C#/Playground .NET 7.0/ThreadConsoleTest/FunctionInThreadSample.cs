using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace ThreadConsoleTest
{
    public class FunctionInThreadSample
    {
        public static void Usage()
        {
            Write($"tid:{Thread.CurrentThread.ManagedThreadId}");
            Write("Begin");
            Thread t1 = new Thread(DoWork1);

            Write("Start");
            t1.Start();

            Write("Work");

            Thread t2 = new Thread(DoWork2);
            Write("Start");
            t2.Start();

            Write("Work");

            Write("Join");
            t1.Join();
            Write("Joined");

            Write("Join");
            t2.Join();
            Write("Joined");

            Write("Finished");
            WriteFinish();
        }

        public static void DoWork1()
        {
            Write($"tid:{Thread.CurrentThread.ManagedThreadId}");
            Write("Work");
        }
        public static void DoWork2()
        {
            Write($"tid:{Thread.CurrentThread.ManagedThreadId}");
            Write("Work");
        }

        private static int PAD = 10;
        private static DateTime start = DateTime.Now;
        private static List<string> memberNames = new List<string>();

        private static void Write(string message, [CallerMemberName] string memberName = "")
        {
            if (!memberNames.Contains<string>(memberName))
            {
                memberNames.Add(memberName);
            }
            int index = memberNames.IndexOf(memberName);

            double diff = (DateTime.Now - start).TotalSeconds;

            string time = $"{diff,5:F2}".PadLeft(5);
            string member = $"{memberName}".PadRight(20);
            message = "".PadLeft(index * PAD) + ":" + message;

            Console.WriteLine($"{time}:{member}:{message}");
        }
        private static void WriteFinish()
        {
            string line = "Time ".PadRight(5) + ":" + "Member".PadRight(20);
            foreach (string member in memberNames)
            {
                line += ":" + member.PadRight(PAD);
            }
            Console.WriteLine(line);
        }
    }
}