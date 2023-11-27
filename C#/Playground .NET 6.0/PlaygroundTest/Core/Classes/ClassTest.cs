namespace PlaygroundTest.Core.Classes
{
    [TestClass]
    public class ClassTest
    {
        [TestMethod]
        public void Init()
        {
            Person person = new Person(1, "name");
            Assert.IsNotNull(person);
            Assert.AreEqual(1, person.Id);
            Assert.AreEqual("name", person.Name);
        }
    }

    public class Person
    {
        // methods
        public int Id { get; set; }
        public string Name { get; set; }

        // ctor
        public Person()
        {
        }
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // methods
        public string ToString()
        {
            return $"ID={Id}, Name={Name}";
        }
    }
}