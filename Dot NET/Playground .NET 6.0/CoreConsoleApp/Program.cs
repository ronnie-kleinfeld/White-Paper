namespace CoreConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            float f1 = 123.4f;
            int i1 = 2000;
            Console.WriteLine($"{f1,6} {i1,7}");


            PrintTriangle();
        }

        private static void PrintTriangle()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}