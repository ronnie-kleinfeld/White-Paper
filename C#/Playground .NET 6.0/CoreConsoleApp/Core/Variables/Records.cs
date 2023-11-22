namespace CoreConsoleApp.Core.Variables
{
    public record class CardsRecord(string Suit, string Rank);

    public class Test
    {
        public Test()
        {
            var myCards = new CardsRecord("Heart", "Ace");
            Console.WriteLine(myCards.Rank);
        }
    }
}
