namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class NullableTypesTest
    {
        [TestMethod]
        public void DoUse()
        {
            var taxRate = new Nullable<double>();
            // onsole.WriteLine(taxRate.Value); // Exception
            Console.WriteLine(taxRate.HasValue); // false
            Console.WriteLine(taxRate); // empty
            Console.WriteLine(taxRate.GetValueOrDefault()); // 0
            taxRate = null;
            Console.WriteLine(taxRate); // empty
            taxRate = 0.2;
            Console.WriteLine(taxRate); // 0.2
            Console.WriteLine(taxRate.Value); // 0.2
            taxRate = null;
            Console.WriteLine(taxRate); // empty
        }

        [TestMethod]
        public void DoUseQuestion()
        {
            double? taxRate = null;
            Console.WriteLine(taxRate.HasValue); // false
            Console.WriteLine(taxRate); // empty
            Console.WriteLine(taxRate.GetValueOrDefault()); // 0
            taxRate = null;
            Console.WriteLine(taxRate); // empty
            taxRate = 0.2;
            Console.WriteLine(taxRate); // 0.2
            Console.WriteLine(taxRate.Value); // 0.2
            taxRate = null;
            Console.WriteLine(taxRate); // empty
        }

        [TestMethod]
        public void NullIfIf()
        {
            string a = null;

            Assert.AreEqual("a is null", a ?? "a is null");

            a ??= "some";
            Assert.AreEqual("some", a ?? "a is null");

            a = "Something";
            Assert.AreEqual("Something", a ?? "a is NOT null");
        }
    }
}