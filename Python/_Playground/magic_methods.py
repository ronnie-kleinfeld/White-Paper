# https://rszalski.github.io/magicmethods/


class Point:
    # init
    def __init__(self, x, y):
        self.x = x
        self.y = y

    # default is <__main__.Point object at 0x108e65940>
    def __str__(self) -> str:
        return f"Point {self.x, self.y}"

    def __eq__(self, __value: object) -> bool:
        return self.x == __value.x and self.y == __value.y

    def __gt__(self, __value: object) -> bool:
        return self.x > __value.x or self.y > __value.y

    def __add__(self, __value: object):
        return Point(self.x + __value.x, self.y + __value.y)


# __str__
point1 = Point(1, 2)
print(point1)  # __str__: Point (1, 2)

# __eq__
point2 = Point(1, 2)
print(point1 == point2)  # True

# __gt__
print(point1 > point2)  # False
point1.x = 3
print(point1 > point2)  # True

# __add__
print(point1 + point2)  # Point (4, 4)
