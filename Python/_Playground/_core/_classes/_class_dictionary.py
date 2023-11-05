class TagCloud:
    def __init__(self) -> None:
        self.tags = {}  # private attribute

    def add(self, tag):
        self.tags[tag.lower()] = self.tags.get(tag.lower(), 0) + 1

    def __getitem__(self, tag):
        return self.tags.get(tag.lower(), 0)

    def __setitem__(self, key, value):
        self.tags[key.lower()] = value

    def __len__(self):
        return len(self.tags)

    def __iter__(self):
        return iter(self.tags)


cloud = TagCloud()
cloud.add("Python")
cloud.add("python")
cloud.add("python")
print(cloud.tags)  # {'python': 3}

print(cloud["PYTHON"])  # 3
cloud["java"] = 2
print(cloud.tags)  # {'python': 3, 'java': 2}

print(len(cloud))  # 2

for tag in cloud:
    print(tag)
