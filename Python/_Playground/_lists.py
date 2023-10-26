import random

# lists
print("CTOR")
print([1, 2, 3])  # [1, 2, 3]
print(list("Ronnie"))  # ['R', 'o', 'n', 'n', 'i', 'e']
print(list(range(5)))  # [0, 1, 2, 3, 4]
print(list("abc") + list(range(3)))  # ['a', 'b', 'c', '0', '1', '2']
print(list("0" * 4))  # ['0', '0', '0', '0']
print(list("1") * 4)  # ['1', '1', '1', '1']
print([i * 2 for i in range(10) if i < 7])  # [0, 2, 4, 6, 8, 10, 12]
print([random.randint(1, 9) for i in range(10)])  # [6, 9, 1, 7, 7, 5, 4, 5, 2, 2]

items = [
    ("Product1", 10),
    ("Product3", 9),
    ("Product2", 12),
]
print([item[1] for item in items])  # [10, 9, 12]
print([item[0] for item in items if item[1] >= 10])  # ['Product1', 'Product2']

print("CASTING")
print(list((1, 2, 3)))  # tuple to [1, 2, 3]
print(list("Ronnie"))  # string to ['R', 'o', 'n', 'n', 'i', 'e']

print("LEN")
print(len(["R", "o", "n", "n", "i", "e"]))  # 6

print("GETTER - LIKE STRING")
letters = list("abcdef")
print(letters[0])  # a
print(letters[1:3])  # ['b', 'c']
print(letters[:3])  # ['a', 'b', 'c']
print(letters[3:])  # ['d', 'e', 'f']
print(letters[:])  # ['a', 'b', 'c', 'd', 'e', 'f']
print(letters[-1])  # f
print(letters[-2:])  # ['e', 'f']
print(letters[:-2])  # ['a', 'b', 'c', 'd']
print(letters[0:3:2])  # ['a', 'c']
print(letters[::2])  # ['a', 'c', 'e']
print(letters[::-1])  # ['f', 'e', 'd', 'c', 'b', 'a']
print(letters[::-2])  # ['f', 'd', 'b']

print("SETTER")
letters = ["a", "b", "c", "d", "e", "f"]
print(letters)  # ['a', 'b', 'c', 'd', 'e', 'f']
letters[0] = "A"
print(letters)  # ['A', 'b', 'c', 'd', 'e', 'f']

print("UNPACKING")
numbers = [1, 2, 3]
first, second, third = numbers  # first = 1, second = 2, third = 3
numbers = [1, 2, 3, 4, 4, 5]
first, second, *others = numbers  # first = 1, second = 2, others = [3, 4, 4, 5]
print(others)

print("ITER")
names = list("Ronnie")
for name in names:
    print(name)
for iter in enumerate(names):
    print(iter, iter[0], iter[1])  # iter = (0, 'R')
for index, name in enumerate(names):
    print(index, name)
for i in range(len(names)):
    print(i, names[i])

print("ADD, DELETE")
abc = ["a", "b", "c", "d"]
print(abc)  # ['a', 'b', 'c', 'd']
print(abc.append("e"))  # None
print(abc)  # ['a', 'b', 'c', 'd', 'e']
print(abc.insert(2, "f"))  # None
print(abc)  # ['a', 'b', 'f', 'c', 'd', 'e']
print(abc.pop())  # e
print(abc)  # ['a', 'b', 'f', 'c', 'd']
print(abc.pop(3))  # c
print(abc)  # ['a', 'b', 'f', 'd']
print(abc.remove("b"))  # None
print(abc)  # ['a', 'f', 'd']
del abc[0:2]
print(abc)  # ['d']
abc.clear()
print(abc)  # []

print("INDEX")
abc = ["a", "b", "c", "c"]
print(abc.index("c"))  # 2
# print(abc.index("e"))  # ValueError: 'e' is not in list
if "c" in abc:
    print("Exists")
print(abc.count("c"))  # 2
print(abc.count("d"))  # 0

print("SORT")
nums = [3, 51, 2, 8, 6]
print(nums.sort())  # None
print(nums)  # [2, 3, 6, 8, 51]
print(nums.sort(reverse=True))  # None
print(nums)  # [51, 8, 6, 3, 2]

sorted(nums)

print("SORT WITH FUNCTION")
items = [
    ("Product1", 10),
    ("Product3", 9),
    ("Product2", 12),
]
print(items.sort())  # [('Product1', 10), ('Product2', 12), ('Product3', 9)]


def sort_item(item):
    return item[1]


print("LAMBDA")
print(
    items.sort(key=sort_item)
)  # [('Product3', 9), ('Product1', 10), ('Product2', 12)]

print(
    items.sort(key=lambda item: item[1], reverse=True)
)  # [('Product2', 12), ('Product1', 10), ('Product3', 9)]

print("MAP")
print(list(map(lambda item: item[1], items)))  # [12, 10, 9]

print("FILTERS")
print(
    list(filter(lambda item: item[1] >= 10, items))
)  # [('Product2', 12), ('Product1', 10)]

print("ZIP")
list1 = [1, 2, 3]
list2 = [10, 20, 30]
print(list(zip("abc", list1, list2)))  # [('a', 1, 10), ('b', 2, 20), ('c', 3, 30)]
