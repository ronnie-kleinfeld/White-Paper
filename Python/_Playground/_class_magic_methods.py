# https://rszalski.github.io/magicmethods/


class Point:
    # init
    def __init__(self, x, y):
        self.x = x
        self.y = y

    def __str__(self) -> str:
        return f"Point {self.x, self.y}"

    def __eq__(self, __value: object) -> bool:
        return self.x == __value.x and self.y == __value.y

    def __gt__(self, __value: object) -> bool:
        return self.x > __value.x or self.y > __value.y

    def __add__(self, __value: object):
        return Point(self.x + __value.x, self.y + __value.y)


point1 = Point(1, 3)
point2 = Point(1, 3)
point3 = Point(1, 2)

print(point1)  # __str__: Point (1, 3)
print(point1 == point2)  # __eq__: True
print(point1 > point3)  # __gt__: True
print(point1 < point3)  # __gt__: False
print(point1 + point2 + point3)  # __add__: Point (3, 8)
