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

            float f1 = 123.4f;
            int i1 = 2000;
            Assert.AreEqual($"{f1,6}", " 123.4");
            Assert.AreEqual($"{i1,7}", "   2000");
        }
    }
}