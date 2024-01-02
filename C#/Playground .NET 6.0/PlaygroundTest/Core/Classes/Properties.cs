namespace PlaygroundTest.Core.Classes
{
    internal class Properties
    {
        public void Usage()
        {
            var book1 = new Book("123");
            // var book2 = new Book { ReadonlyProp = "123" }; readonly value can not be assigned in an expersion initilizer
            // book2.ISBN = ""; readonly, can not be assigned

            var book3 = new Book() { InitProp = "The Book" }; // init value can be assigned in an expersion initilizer
        }
    }

    public class Book
    {
        public const string ID = "123"; // assigned on compile time
        public readonly string ReadonlyProp = ""; // readnonly can only be initialized here and

        public string InitProp { get; init; } // like readonly but can be assigned in a expresion initializer

        public Book() { }
        public Book(string ReadonlyProp)
        {
            this.ReadonlyProp = ReadonlyProp; // readnonly can only be initialized here and
        }

        public void Update(string ReadonlyProp, string InitProp)
        {
            // this.ReadonlyProp = ReadonlyProp; // readonly
            // this.InitProp = InitProp; // init
        }
    }
}