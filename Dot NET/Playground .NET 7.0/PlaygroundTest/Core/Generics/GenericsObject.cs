using PlaygroundTest.Core.Generics;

namespace PlaygroundTest.Core.Generics
{
    public static class GenericsObject
    {
        public static void DoUse()
        {
            var stackerGeneric = new ObjectStacker();
            stackerGeneric.Push(4);
            stackerGeneric.Push("Ronnie");
            stackerGeneric.Pop();

            var stackerInt = new Stacker<int>();
            stackerInt.Push(4);
            stackerInt.Push(5);
            stackerInt.Pop();

            var stackerBoolean = new Stacker<bool>();
            stackerBoolean.Push(true);
            stackerBoolean.Push(false);
            stackerBoolean.Pop();
        }
    }

    public class ObjectStacker
    {
        int position;
        object[] items = new object[20];
        public void Push(object item)
        {
            items[position++] = item;
        }
        public object Pop()
        {
            return items[--position];
        }
    }

    public class Stacker<T>
    {
        int position;
        T[] items = new T[20];
        public void Push(T item)
        {
            items[position++] = item;
        }
        public T Pop()
        {
            return items[--position];
        }
    }
}
