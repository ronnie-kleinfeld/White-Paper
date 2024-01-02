namespace PlaygroundTest.Core.Classes
{
    internal class ObjectInitializer
    {
        Dog dog = new Dog { Name = "Fido", Age = 4, IsTrained = true };
        Cat cat = new Cat { Name = "Mr. Meowington", Age = 7, IsDeclawed = false };

        PetOwner owner = new PetOwner
        {
            Name = "Joe Marini",
            Pets = new List<Pet> {
        new Dog {Name = "Junebug", Age = 4},
        new Cat {Name = "Whiskers", Age = 3},
        new Dog {Name = "Max", Age = 10}
    }
        };
    }

    public class Pet
    {
        public string Name { get; set; } = "";
        public int Age { get; set; } = 0;

        public Pet() { }
    }

    public class Dog : Pet
    {
        public bool IsTrained { get; set; } = false;

        public Dog() { }
    }

    public class Cat : Pet
    {
        public bool IsDeclawed { get; set; } = false;

        public Cat() { }
    }

    public class PetOwner
    {
        public string Name { get; set; } = "";

        public List<Pet>? Pets { get; set; }
    }
}