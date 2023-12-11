import math

list1 = [1, 2, 3, 4, 5]
list2 = [[i**2, i**3, i**4] for i in list1]

print(list1)
print(list2)

table = [[i] * 10 for i in range(10)]
print("B")
for i in range(10):
    print(table[i])

for i in range(1, 10):
    for j in range(1, 10):
        table[i][j] = i * j
print("C")
for i in range(10):
    print(table[i])
