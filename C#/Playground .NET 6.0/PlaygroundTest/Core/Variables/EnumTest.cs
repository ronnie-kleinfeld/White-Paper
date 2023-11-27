namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class EnumTest
    {
        [TestMethod]
        public void Init()
        {
        }
    }

    public enum GenderEnum : int // default enum value is int
    {
        Male = 1,
        Female = 2,
        Other = 3
    }
    public class Person
    {
        // methods
        public string Name { get; set; }
        public GenderEnum Gender { get; set; }

        // ctor
        public Person()
        {
            Name = "";
            Gender = GenderEnum.Other;
        }
        public Person(string name, GenderEnum gender)
        {
            Name = name;
            Gender = gender;
        }
    }
}