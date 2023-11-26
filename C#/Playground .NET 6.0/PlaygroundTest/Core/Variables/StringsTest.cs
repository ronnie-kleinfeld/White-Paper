using System.Runtime.Intrinsics.Arm;

namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class StringsTest
    {
        [TestMethod]
        public void Init()
        {
            string str = null;
            Assert.AreEqual(str, null);
            str = default;
            Assert.AreEqual(str, null);
            str = "Ronnie";
            Assert.AreEqual(str, "Ronnie");
            str = string.Empty;
            Assert.AreEqual(str, "");

            Assert.AreEqual("aaaaa", new string('a', 5));
        }

        [TestMethod]
        public void EscapeSequence()
        {
            string str = "First\"\'\\\rEnter\nNewLine\tTab\vVerticalTab\bbackspace\aAlert";
            Console.WriteLine(str);
        }

        [TestMethod]
        public void Unicode()
        {
            Console.WriteLine("ঙ");
            Assert.AreEqual("ঙ", "\u0999");
        }

        [TestMethod]
        public void Basic()
        {
            Assert.AreEqual("Ronnie".Length, 6);

            Assert.AreEqual("Ronnie"[0], 'R');
            Assert.AreEqual("Ronnie"[4], 'i');

            // "Ronnie"[0] = 'B'; this is IMPOSIBBLE, string are IMUTABLE

            Assert.AreEqual("Ronnie".Replace("nn", "ll"), "Rollie");

            Assert.AreEqual("Ronnie" + "Kleinfeld", "RonnieKleinfeld");
            Assert.AreEqual(String.Concat("Ronnie", "Kleinfeld"), "RonnieKleinfeld");

            string[] strs = { "one", "two", "three", "four" };

            Assert.AreEqual(String.Join('.', strs), "one.two.three.four");
            Assert.AreEqual(String.Join(string.Empty, strs), "onetwothreefour");

            Assert.AreEqual("Ronnie Shira Roy Yahli".Split(' ')[1], "Shira");

            Assert.AreEqual("Ronnie".Replace("Ronn", "Coff"), "Coffie");
        }

        /// <summary>
        /// string is a reference type but it is IMUTABLE so it does not behave like a class in this case
        /// </summary>
        [TestMethod]
        public void StringIsImutable()
        {
            string s1 = "Ronnie";
            string s2 = s1; // this create a new object for string s2 and not set a pointer to s1 object as any other reference type would
            Assert.AreEqual(s1, s2);
            Assert.AreEqual(s1, "Ronnie");
            Assert.AreEqual(s2, "Ronnie");

            s2 = "Kleinfeld";
            Assert.AreEqual(s1, "Ronnie");
            Assert.AreEqual(s2, "Kleinfeld");

            s2 = "Shira";
            Assert.AreEqual(s1, "Ronnie");
            Assert.AreEqual(s2, "Shira");
        }

        [TestMethod]
        public void Iter()
        {
            string str1 = "This is a string";

            foreach (Char ch in str1)
            {
                Console.Write(ch);
                if (ch == 'a')
                {
                    Console.WriteLine();
                    break;
                }
            }
        }

        [TestMethod]
        public void Search()
        {
            string str1 = "Ronnie";

            Assert.AreEqual(true, str1.Contains("onn"));
            Assert.AreEqual(false, str1.Contains("Onn"));
            Assert.AreEqual(true, str1.Contains("Onn", StringComparison.CurrentCultureIgnoreCase));

            Assert.AreEqual(true, str1.StartsWith("Ro"));
            Assert.AreEqual(true, str1.EndsWith("ie"));

            Assert.AreEqual(2, str1.IndexOf("n"));
            Assert.AreEqual(3, str1.LastIndexOf("n"));

            Assert.AreEqual(true, String.IsNullOrEmpty(null));
            Assert.AreEqual(true, String.IsNullOrEmpty(string.Empty));
            Assert.AreEqual(true, String.IsNullOrEmpty(""));
            Assert.AreEqual(false, String.IsNullOrEmpty(" "));
            Assert.AreEqual(true, String.IsNullOrWhiteSpace(" "));
        }

        [TestMethod]
        public void Cast()
        {
            MyObject myObject = new MyObject();
            myObject.ID = 7;

            Assert.AreEqual("7", myObject.ToString());
            Assert.AreEqual("a7", "a" + myObject.ToString());
        }
        private class MyObject : Object
        {
            public int ID;
            public override string ToString()
            {
                return $"{ID}";
            }
        }

        [TestMethod]
        public void Verbatim()
        {
            string str = @"Dear Ronnie,
I hope this email finds you well.
Regards,
Ronnie";
            Assert.AreEqual(str, "Dear Ronnie,\r\nI hope this email finds you well.\r\nRegards,\r\nRonnie");
            Console.WriteLine(str);
        }

        [TestMethod]
        public void Interpolation()
        {
            string str1 = "Ronnie";
            string str2 = "Kleinfeld";
            Assert.AreEqual($"{str1} {str2}", "Ronnie Kleinfeld");

            Console.WriteLine($"C - Currency    {1234,11:C2}"); // ₪ 1,234.00
            Console.WriteLine($"D - Decimal     {1234,11:D2}"); // 1234
            Console.WriteLine($"E - Exponential {1234,11:E2}"); // 1.23E+003
            Console.WriteLine($"F - Fixed-point {1234,11:F2}"); // 1234.00
            Console.WriteLine($"G - General     {1234,11:G2}"); // 1.2E+03
            Console.WriteLine($"N - Number      {1234,11:N2}"); // 1,234.00
            Console.WriteLine($"P - Percent     {1234,11:P2}"); // 123,400.00%
            Console.WriteLine($"X - Hexadecimal {1024,11:X2}"); // 400
        }
    }
}