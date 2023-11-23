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
        public void StringInterpolation()
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