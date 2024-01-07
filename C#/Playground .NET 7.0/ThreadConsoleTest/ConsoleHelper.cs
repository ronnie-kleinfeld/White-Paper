using System.Runtime.CompilerServices;

namespace ThreadConsoleTest
{
    public class ConsoleHelper
    {
        public static int PAD = 20;
        private static DateTime start = DateTime.Now;
        private static List<string> memberNames = new List<string>();

        public static void WriteLine(string message, [CallerMemberName] string memberName = "")
        {
            if (!memberNames.Contains<string>(memberName))
            {
                memberNames.Add(memberName);
                WriteLine(memberName + "()", memberName);
            }
            int index = memberNames.IndexOf(memberName);

            double diff = (DateTime.Now - start).TotalSeconds;

            string time = $"{diff,7:F4}".PadLeft(7);
            //string member = $"{memberName}".PadRight(20);
            string padding = "";
            for (int i = 0; i < index; i++)
            {
                padding += "".PadLeft(PAD) + ":";
            }

            //Console.WriteLine($"{time}:{member}{padding}{message}");
            Console.WriteLine($"{time}:{padding}{message}");
        }
        public static void WriteLine(int threadId, [CallerMemberName] string memberName = "")
        {
            WriteLine($"tid={threadId}", memberName);
        }
        internal static void DoTitle()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            int i = 0;
            while (i < 1000000)
            {
                Console.Title = i.ToString();
                i++;
            }
            ConsoleHelper.WriteLine("done");
        }
    }
}