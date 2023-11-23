namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class StringsTest
    {
        [TestMethod]
        public void Init()
        {
            string str1 = "Ronnie";
            Assert.AreEqual(str1, "Ronnie");

            Assert.AreEqual(str1.Length, 6);

            Assert.AreEqual(str1[0], 'R');
            Assert.AreEqual(str1[4], 'i');

            Assert.AreEqual(String.Concat("Ronnie", "Kleinfeld"), "RonnieKleinfeld");

            string[] strs = { "one", "two", "three", "four" };

            Assert.AreEqual(String.Join('.', strs), "one.two.three.four");
            Assert.AreEqual(String.Join(string.Empty, strs), "onetwothreefour");

            Assert.AreEqual(str1.Replace("Ronn", "Coff"), "Coffie");
        }

        [TestMethod]
        public void Iter()
        {
            string str1 = "This is a string";

            foreach (Char ch in str1)
            {
                Console.Write(ch);
                if (ch == 'b')
                {
                    Console.WriteLine();
                    break;
                }
            }
        }

        [TestMethod]
        public void Search()
        {
            // LinkedIn Learning Course .NET Programming with C# by Joe Marini
            // Example file for searching string content

            string teststr = "The quick brown Fox jumps over the lazy Dog";

            // Contains determines whether a string contains certain content
            Console.WriteLine($"{teststr.Contains("fox")}");
            Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}");

            // StartsWith and EndsWith determine if a string starts 
            // or ends with a given test string
            Console.WriteLine($"{teststr.StartsWith("the")}");
            Console.WriteLine($"{teststr.StartsWith("the", StringComparison.CurrentCultureIgnoreCase)}");
            Console.WriteLine($"{teststr.EndsWith("dog")}");
            Console.WriteLine($"{teststr.EndsWith("dog", StringComparison.CurrentCultureIgnoreCase)}");

            // IndexOf, LastIndexOf finds the index of a substring
            Console.WriteLine($"{teststr.IndexOf("the")}");
            Console.WriteLine($"{teststr.IndexOf("the", StringComparison.CurrentCultureIgnoreCase)}");
            Console.WriteLine($"{teststr.LastIndexOf("the")}");

            // Determining empty, null, or whitespace
            string str1 = null;
            string str2 = "   ";
            string str3 = String.Empty;
            Console.WriteLine($"{String.IsNullOrEmpty(str1)}");
            Console.WriteLine($"{String.IsNullOrEmpty(str3)}");
            Console.WriteLine($"{String.IsNullOrWhiteSpace(str2)}");
        }

        [TestMethod]
        public void StringInterpolation()
        {
            string str1 = "Ronnie";
            string str2 = "Kleinfeld";
            Assert.AreEqual($"{str1} {str2}", "Ronnie Kleinfeld");

            float f1 = 123.4f;
            int i1 = 2000;
            Assert.AreEqual($"{f1,6}", " 123.4");
            Assert.AreEqual($"{i1,7}", "   2000");
        }
    }
}