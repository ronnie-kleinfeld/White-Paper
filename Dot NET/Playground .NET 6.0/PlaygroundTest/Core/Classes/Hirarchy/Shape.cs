namespace PlaygroundTest.Core.Classes.Hirarchy
{
    internal abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
        }

        public abstract string Draw();
        public virtual double Area()
        {
            return 0;
        }
    }

    internal sealed class Box : Shape
    {
        public override string Draw()
        {
            return "I am a Box";
        }
    }

    internal class Circle : Shape
    {
        public override string Draw()
        {
            return "I am a Circle";
        }
        public override double Area()
        {
            return Math.PI * Width * Width;
        }
    }

    public class Main
    {
        public void main()
        {
            // var shape = new Shape();
            var shape1 = new Box();
            var shape2 = new Circle();

            Console.WriteLine(shape1 is Box);
            Console.WriteLine(shape1 is Circle);
            Console.WriteLine(shape1 is Shape);
        }
    }
}
