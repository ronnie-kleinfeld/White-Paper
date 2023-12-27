namespace PlaygroundTest.Core.Classes
{
    [TestClass]
    public class ClassTest
    {
        [TestMethod]
        public void Init()
        {
            // class
            Person person = new Person(1, "name");
            Assert.IsNotNull(person);
            Assert.AreEqual(1, person.Id);
            Assert.AreEqual("name", person.Name);

            // objet initializers
            Person person2 = new Person
            {
                Name = "Ronnie"
            };

            Customer customer = new Customer(1, "name");
        }
    }
}