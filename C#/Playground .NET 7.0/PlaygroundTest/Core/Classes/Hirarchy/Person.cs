namespace PlaygroundTest.Core.Classes.Hirarchy
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
            Name = string.Empty;
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
