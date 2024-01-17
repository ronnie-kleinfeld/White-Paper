using System.Numerics;

namespace Playground_.NET_7._0
{
    public class TestClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello .Net 7");

            var e = new Emp();
            e.Add(5, 6);
            Console.WriteLine(e.Add('c', 'f'));
        }
    }


    public class Emp
    {
        public T Add<T>(T left, T right) where T : INumber<T>
        {
            return left + right;
        }
    }
}