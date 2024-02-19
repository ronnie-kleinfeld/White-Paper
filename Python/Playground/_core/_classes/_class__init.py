class Point:
    # static members
    color = "111"  # Point.color = "222"

    # static class methods
    @classmethod
    def blabla(cls):  # Point.blabla() returns a point object
        return cls(10, 10)

    # static methods
    @staticmethod
    def blublu(blu):  # Point.blublu()
        print(blu)

    # members
    # initialized in init or inline when needed

    # ctor
    def __init__(self, x, age=0):  # point = Point(1)
        self.x = x  # public member
        self.age = age  # public member with default value
        self.__height = 4  # "private" member
        self.z = 5  # public member defined inline
        self.color = "aaa"  # public member defined inline, duplicates the static member

    # methods
    def draw(self):  # point.draw()
        print("Draw")


point0 = Point.blabla()
print("blabla", point0.age)

Point.blublu(7)

point1 = Point(1, 1)
print(point1)  # <__main__.Point object at 0x101830200>
print(type(point1))  # <class '__main__.Point'>
print(isinstance(point1, Point))  # True

print(
    point1.__dict__
)  # {'x': 1, 'age': 1, '_Point__height': 4, 'z': 5, 'color': 'aaa'}
print(point1._Point__height)  # access "private" member


point2 = Point(2, 2)

point1.draw()
point2.draw()

Point.color = "222"
point1.draw()
point2.draw()

point2.color = "333"
point1.draw()
point2.draw()

Point.color = "444"
point1.draw()
point2.draw()

point2.color = "555"
point1.draw()
point2.draw()

point1.color = "666"
point1.draw()
point2.draw()

Point.color = "777"
point1.draw()
point2.draw()

blabla = Point.blabla()
blabla.draw()
