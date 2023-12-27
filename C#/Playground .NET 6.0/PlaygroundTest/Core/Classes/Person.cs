namespace PlaygroundTest.Core.Classes
{
    public class Person
    {
        // members
        public int Id { get; set; }
        public string Name { get; set; }

        // properties


        // ctor
        public Person()
        {
            this.Name = string.Empty;
        }
        public Person(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        // methods
        public string ToString()
        {
            return $"ID={Id}, Name={Name}";
        }
    }
}
