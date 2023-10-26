class TagCloud:
    def __init__(self, price) -> None:
        self.price = price

    def __get_price(self):
        return self.__price

    def __set_price(self, value):
        if value < 0:
            raise ValueError("Price cannot be negative.")
        self.__price = value

    price = property(__get_price, __set_price)


cloud = TagCloud(5)
# cloud.set_price(-5)  # ValueError: Price cannot be negative.
cloud._TagCloud__set_price(7)
print(cloud.price)
# cloud.price = -8  # ValueError: Price cannot be negative.
cloud.price = 8
print(cloud.price)
