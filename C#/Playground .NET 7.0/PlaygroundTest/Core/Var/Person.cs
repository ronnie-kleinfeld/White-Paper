namespace PlaygroundTest.Core.Var
{
    public abstract class Person : IPerson
    {
        public string name1A;
        public string name1B;

        public string Do1A() => "Person Do1A";
        public abstract string Do1B();
        public virtual string Do1C() => "Person Do1C";
        public new string Do1D() => "Person Do1D";

        public string Do2A() => "Person Do2A";
        public abstract string Do2B();
        public virtual string Do2C() => "Person Do2C";
        public new string Do2D() => "Person Do2D";

        public string Do3A() => "Person Do3A";
        public abstract string Do3B();
        public virtual string Do3C() => "Person Do3C";
        public new string Do3D() => "Person Do3D";
    }
}