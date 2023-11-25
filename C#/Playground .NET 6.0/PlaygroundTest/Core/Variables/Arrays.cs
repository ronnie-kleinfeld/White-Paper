namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void Init()
        {
            int[] numbers = new int[8];
            Assert.AreEqual(8, numbers.Length);

            double[] taxRates = { 3.5, 5.8, 3.1 };
            Assert.AreEqual(taxRates.Length, 3);

            var letters = new Char[] { 'a', 'b', 'c', 'd' };
            Assert.AreEqual(letters.Length, 4);
            Assert.AreEqual('a', letters[0]);
            Assert.AreEqual('b', letters[1]);
            Assert.AreEqual('c', letters[2]);
            Assert.AreEqual('d', letters[3]);
        }

        [TestMethod]
        public void GroupBy()
        {
            string str = "a, b, a, a, c, d, e, e";
            var foods = str.Split(", ");
            Console.WriteLine(foods.Where(x => x.Contains('a')));

            var countFoods = foods.GroupBy(x => x).Where(x => x.Count() > 1);

            foreach (var food in countFoods)
            {
                Console.WriteLine($"{food.Key} {food.Count()}");
            }
        }
    }
}