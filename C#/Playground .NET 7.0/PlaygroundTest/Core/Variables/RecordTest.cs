namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class RecordTest
    {
        [TestMethod]
        public void Test()
        {
            var c1 = new CardsRecord("Heart", "Ace");
            Assert.AreEqual("Heart", c1.Suit);
            Assert.AreEqual("Ace", c1.Rank);

            (var suit, var rank) = c1;
            Assert.AreEqual("Heart", suit);
            Assert.AreEqual("Ace", rank);

            var c2 = new CardsRecord("Diamond", "8");
            var c3 = new CardsRecord("Heart", "Ace");

            Console.WriteLine(c1.ToString());

            Assert.AreEqual("CardsRecord { Suit = Heart, Rank = Ace, Desc = Heart\\Ace }", c1.ToString());

            Assert.IsTrue(c1 == c3);
            Assert.IsFalse(c1 == c2);

            Console.WriteLine($"{c1.Desc}");

            var c4 = c3 with { Suit = "Spade" };
            Assert.AreEqual("Spade", c4.Suit);
        }
    }

    public record class CardsRecord(string Suit, string Rank)
    {
        public string Desc => $"{Suit}\\{Rank}";
    }
}