namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class EnumTest
    {
        [TestMethod]
        public void Init()
        {
            GenderEnum gender = GenderEnum.Other;
            Assert.AreEqual(GenderEnum.Other, gender);
            Assert.AreEqual(3, (int)gender);

            Assert.AreEqual(1, (int)GenderEnum.Male);
            Assert.AreEqual(GenderEnum.Female, (GenderEnum)2);
            Assert.AreEqual(GenderEnum.Female.ToString(), "Female");
            Assert.AreEqual(GenderEnum.Other, Enum.Parse(typeof(GenderEnum), "Other"));
        }
    }

    /// <summary>
    /// default enum value is int
    /// first item value defaults to 0 and ++ each others
    /// </summary>
    public enum GenderEnum : int
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