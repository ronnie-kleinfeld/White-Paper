class TagCloud:
    def __init__(self, age) -> None:
        self.age = age

    @property
    def age(self):
        return self.__age

    @age.setter
    def age(self, value):
        if value < 0:
            raise ValueError("Age cannot be negative.")
        self.__age = value


cloud = TagCloud(17)
print(cloud.age)  # 17
# cloud.age = -53  # ValueError: Age cannot be negative.
cloud.age = 53
print(cloud.age)  # 53
