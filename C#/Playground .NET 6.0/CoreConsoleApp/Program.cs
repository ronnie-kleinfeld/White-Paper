using CoreConsoleApp.Core.Variables;

namespace CoreConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PrintTriangle();
            PrimitiveTypes.PT();
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