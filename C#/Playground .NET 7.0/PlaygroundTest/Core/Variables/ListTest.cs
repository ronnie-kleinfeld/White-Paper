namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void Init()
        {
            var numbers1 = new List<int>();
            Assert.IsNotNull(numbers1);
            Assert.AreEqual(0, numbers1.Count);

            var numbers2 = new List<double>() { 3.5, 5.8, 3.1 };
            Assert.IsNotNull(numbers2);
            Assert.AreEqual(3, numbers2.Count);
        }

        [TestMethod]
        public void Operations()
        {
            List<int> numbers = new List<int>();
            numbers.Add(4);
            numbers.Remove(4);
            numbers.RemoveAll(x => x > 5);
            numbers.IndexOf(4);
            numbers.Contains(4);
            numbers.Count();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}