using PlaygroundTest.Core.Generics;

namespace PlaygroundTest.Core.Generics
{
    /// <summary>
    /// restricts T to inherit from class or implement an interface
    /// where T : struct        - must be value type
    /// where T : class         - must be a reference type
    /// where T : <base class>  - must inherit from base class
    /// where T : <interface>   - must implement the interface
    /// where T : U             - T must inherit from U
    /// where T : new()         - must have a public parameterless constructor, not abstract class
    /// </summary>

    public class GenericsConstraints
    {
        public static void main()
        {
            var s = new Sorter<int>();

        }
    }

    public class Sorter<T> where T : IComparable<T>, new()
    {
        public int Comparable<T>(T item1, T item2) where T : IComparable
        {
            return item1.CompareTo(item2);
        }
    }
}
