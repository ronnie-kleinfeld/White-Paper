namespace PlaygroundTest.Core.Var
{
    public class Employee : Person
    {
        public string name1A;
        public new string name1B;

        public string name2A;

        public override string Do1B() => "Employee Do1B";
        public override string Do2B() => "Employee Do1B";
        public override string Do3B() => "Employee Do3B";
    }
}