namespace PlaygroundTest.Core.Interfaces
{
    [TestClass]
    public class IEquatableTest
    {
        [TestMethod]
        public void Test()
        {
            Book b1 = new Book() { SKU = "12345" };
            Book b2 = new Book() { SKU = "12345" };
            Book b3 = new Book() { SKU = "23456" };

            Assert.IsTrue(b1.Equals(b2));

            Assert.IsFalse(b1.Equals(b3));
            Assert.IsFalse(b2.Equals(b3));
        }
    }

    public struct Book : IEquatable<Book>
    {
        public string SKU { get; set; }
        public string Name { get; set; }

        bool IEquatable<Book>.Equals(Book other)
        {
            return this.SKU == other.SKU;
        }
    }
}