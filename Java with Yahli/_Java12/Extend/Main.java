package Extend;

public class Main {
    public static void main(String[] args) {
        // Using the interface
        IAnimal animal = new Dog("Buddy", 3);
        animal.makeSound();
        animal.move();

        // Using inheritance
        GuardDog guardDog = new GuardDog("Rex", 5, "warehouse", true);
        guardDog.makeSound(); // from Dog
        guardDog.move(); // from Dog
        guardDog.guard(); // from GuardDog

        // Casting example
        Dog dog = guardDog; // Upcasting (GuardDog to Dog)
        if (dog instanceof GuardDog) {
            GuardDog downcasted = (GuardDog) dog; // Downcasting back to GuardDog
            downcasted.guard();
        }
    }
}
