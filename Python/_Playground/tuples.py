import random

# tuple
print("CTOR")
tuple1 = (1, 2, 3)
print(tuple1, type(tuple1))  # (1, 2, 3)
tuple1 = 1, 2
print(tuple1, type(tuple1))  # (1, 2) <class 'tuple'>
tuple1 = (1,)
print(tuple1, type(tuple1))  # (1, ) <class 'tuple'>
tuple1 = ()
print(tuple1, type(tuple1))  # () <class 'tuple'>
tuple1 = tuple("abc")
print(tuple1, type(tuple1))  # ('a', 'b', 'c')
tuple1 = tuple(range(5))
print(tuple1, type(tuple1))  # (0, 1, 2, 3, 4)
tuple1 = ("a", "b", "c") + (1, 2, 3)
print(tuple1, type(tuple1))  # ('a', 'b', 'c', '1', '2', '3')
tuple1 = ("a", "b") * 3
print(tuple1, type(tuple1))  # ('a', 'b', 'a', 'b', 'a', 'b')
tuple1 = tuple(i * 2 for i in range(10) if i < 7)
print(tuple1, type(tuple1))  # (0, 2, 4, 6, 8, 10, 12)
tuple1 = tuple(random.randint(1, 9) for i in range(5))
print(tuple1, type(tuple1))  # (6, 8, 3, 3, 2)

print("CASTING")
print(tuple([1, 2, 3]))  # list to (1, 2, 3)
print(tuple("Ronnie"))  # string to ('R', 'o', 'n', 'n', 'i', 'e')

print("LEN")
print(len((1, 2, 3)))  # 3

print("GETTER - LIKE STRING")
tuple1 = tuple("abcdef")
print(tuple1[0])  # a
print(tuple1[1:3])  # ('b', 'c')
print(tuple1[:3])  # ('a', 'b', 'c')
print(tuple1[3:])  # ('d', 'e', 'f')
print(tuple1[:])  # ('a', 'b', 'c', 'd', 'e', 'f')
print(tuple1[-1])  # f
print(tuple1[-2:])  # ('e', 'f')
print(tuple1[:-2])  # ('a', 'b', 'c', 'd')
print(tuple1[0:3:2])  # ('a', 'c')
print(tuple1[::2])  # ('a', 'c', 'e')
print(tuple1[::-1])  # ('f', 'e', 'd', 'c', 'b', 'a')
print(tuple1[::-2])  # ('f', 'd', 'b')

print("SETTER")
# TUPLE CAN NOT BE SET

print("UNPACKING")
tuple1 = (1, 2, 3)
a, b, c = tuple1
print(a, b, c)

print("ITER")
tuple1 = "Ronnie"
for t in tuple1:
    print(t)
for iter in enumerate(tuple1):
    print(iter, iter[0], iter[1])  # iter = (0, 'R')
for index, name in enumerate(tuple1):
    print(index, name)
for i in range(len(tuple1)):
    print(i, tuple1[i])

print("SEARCH")
print(2 in (1, 2, 3))  # True
print(2 not in (1, 2, 3))  # False

print(min((1, 2, 3)))  # 1
print(max((1, 2, 3)))  # 3
