package Extend;

class Dog implements IAnimal {
    private String name;
    private int age;

    public Dog() {
        this.name = "";
        this.age = 0;
    }

    public Dog(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public void makeSound() {
        System.out.println(name + " says: Woof!");
    }

    public void move() {
        System.out.println(name + " is running.");
    }

    public String getName() {
        return name;
    }

    public int getAge() {
        return age;
    }
}