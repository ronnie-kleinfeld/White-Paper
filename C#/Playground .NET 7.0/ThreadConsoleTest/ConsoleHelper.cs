using System.Runtime.CompilerServices;

namespace ThreadConsoleTest
{
    public class ConsoleHelper
    {
        public static int PAD = 20;
        private static DateTime start = DateTime.Now;
        private static List<string> memberNames = new List<string>();
        static readonly object lockCompleted = new object();

        public static int GetX([CallerMemberName] string memberName = "")
        {
            if (!memberNames.Contains<string>(memberName))
            {
                memberNames.Add(memberName);
            }
            int index = memberNames.IndexOf(memberName);

            int padding = 0;
            for (int i = 0; i < index; i++)
            {
                padding += PAD + 1;
            }

            return 7 + 1 + 2 + 1 + padding;
        }
        public static void WriteLine(string message, [CallerMemberName] string memberName = "")
        {
            lock (lockCompleted)
            {

                if (!memberNames.Contains<string>(memberName))
                {
                    memberNames.Add(memberName);
                    WriteLine(memberName + "()", memberName);
                }
                int index = memberNames.IndexOf(memberName);

                double diff = (DateTime.Now - start).TotalSeconds;

                string time = $"{diff,7:F4}".PadLeft(7);
                string tid = Thread.CurrentThread.ManagedThreadId.ToString();
                //string member = $"{memberName}".PadRight(20);
                string padding = "";
                for (int i = 0; i < index; i++)
                {
                    padding += "".PadLeft(PAD) + ":";
                }

                //Console.WriteLine($"{time}:{member}{padding}{message}");
                Console.WriteLine($"{time}:{tid,2:F0}:{padding}{message}");
            }
        }
        public static void WriteLine(int threadId, [CallerMemberName] string memberName = "")
        {
            lock (lockCompleted)
            {
                WriteLine($"tid={threadId}", memberName);
            }
        }
        public static void WriteProgress(int y, int counter, int max, [CallerMemberName] string memberName = "")
        {
            lock (lockCompleted)
            {
                Write(y, $"{counter,10:F0}", memberName);
            }
        }
        public static void Write(int y, string message, [CallerMemberName] string memberName = "")
        {
            lock (lockCompleted)
            {
                var (left, top) = Console.GetCursorPosition();
                int x = GetX(memberName);
                Console.SetCursorPosition(x, y);
                Console.Write(message);
                Console.SetCursorPosition(left, top);
            }
        }
        internal static void DoTitleOLD()
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