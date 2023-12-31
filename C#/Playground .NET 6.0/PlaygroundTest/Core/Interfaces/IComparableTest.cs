namespace PlaygroundTest.Core.Interfaces
{
    [TestClass]
    public class IComparableTest
    {
        [TestMethod]
        public static void DoUse()
        {
            Card card1 = new Card();
            card1.Suit = Suit.Spade;
            card1.Rank = Rank.Ace;

            Card card2 = new Card();
            card2.Suit = Suit.Spade;
            card2.Rank = Rank.King;

            Assert.AreEqual(-1, card1.CompareTo(card2));
            Assert.AreEqual(1, card2.CompareTo(card1));
        }
    }

    public struct Card : IComparable<Card>
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public int CompareTo(Card other)
        {
            int sortOrder = 0;
            sortOrder = other.Rank.CompareTo(Rank);
            if (sortOrder == 0)
            {
                sortOrder = other.Suit.CompareTo(Suit);
            }

            return sortOrder;
        }
    }

    public enum Suit
    {
        Spade = 4,
        Heart = 3,
        Club = 2,
        Diamond = 1
    }

    public enum Rank
    {
        Ace = 14,
        King = 13,
        Queen = 12,
        Jack = 11,
        Ten = 10,
        Nine = 9,
        Eight = 8,
        Seven = 7,
        Six = 6,
        Five = 5,
        Four = 4,
        Three = 3,
        Two = 2,
        One = 1
    }
}