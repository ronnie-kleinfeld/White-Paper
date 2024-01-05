﻿using System.Runtime.CompilerServices;

namespace ThreadConsoleTest
{
    public class ConsoleWriterHelper
    {
        private static int PAD = 20;
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
        public static void WriteFinish()
        {
            string line = "Time ".PadRight(7);// + ":" + "Member".PadRight(20);
            foreach (string member in memberNames)
            {
                line += ":" + member.PadRight(PAD);
            }
            Console.WriteLine(line);
        }
    }
}