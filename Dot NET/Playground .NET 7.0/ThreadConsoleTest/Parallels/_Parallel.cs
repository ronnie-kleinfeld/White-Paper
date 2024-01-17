namespace ThreadConsoleTest.Parallels
{
    internal class _Parallel
    {
        public static void Start()
        {
            Parallel.For(0, 100, (ix) => { Console.WriteLine(ix); });

            var numbers = new List<int>();
            for (int ix = 0; ix < 100; ix++)
            {
                numbers.Add(ix);
            }
            Parallel.ForEach<int>(numbers, (ix) => { });
            Console.ReadKey();
        }
    }
}