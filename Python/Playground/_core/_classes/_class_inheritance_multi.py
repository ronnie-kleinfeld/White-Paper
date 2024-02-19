# import the abstract base class
from abc import ABC, abstractmethod


class Animal(ABC):  # abstract class
    def __init__(self) -> None:
        self.age = 0

    def eat(self):
        print("eat")

    @abstractmethod
    def read(self):
        pass


class Mammal(Animal):
    def __init__(self) -> None:
        super().__init__()  # call a function in base class
        self.weight = 0

    def walk(self):
        print("walk")

    def read(self):
        print("mammal reads")


class Fish(Animal):
    def swim(self):
        print("swim")

    def read(self):
        print("fish reads")


# animal = Animal()  # abstract class

mammal = Mammal()
mammal.age = 5
mammal.eat()
mammal.walk()

fish = Fish()
fish.age = 5
fish.eat()
fish.swim()


print(isinstance(mammal, Mammal))  # True
print(isinstance(mammal, Animal))  # True
print(isinstance(mammal, object))  # True
print(issubclass(Mammal, Animal))  # True
print(issubclass(Animal, Mammal))  # False
