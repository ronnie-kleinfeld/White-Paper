namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class IndicesRangesTest
    {
        [TestMethod]
        public void Test()
        {
            string[] words = new string[]
            {
                "The","quick","brown","fox","jumps","over","the","lazy","dog"
            };

            Console.WriteLine(words[1]);    // quick

            Console.WriteLine(words[^1]);   // dog

            Console.WriteLine(words[2..5]); // brown, fox, jumps
            Console.WriteLine(words[..]);   // The, quick, brown, fox, jumps, over, the, lazy, dog
            Console.WriteLine(words[..5]);  // The, quick, brown, fox, jumps
            Console.WriteLine(words[2..]);  // brown, fox, jumps, over, the, lazy, dog

            Index idx = ^4;
            Console.WriteLine(words[idx]);  // over

            Range rng = 3..^1;
            Console.WriteLine(words[rng]);  // fox, jumps, over, the, lazy
        }
    }
}