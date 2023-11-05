import random

list0 = []
for i in range(9):
    list0.append(random.randint(1, 9))

print(list0)

# bubble sort
list1 = list0
for i in range(len(list1)):
    for j in range(len(list1) - 1):
        if list1[j] > list1[j + 1]:
            temp = list1[j]
            list1[j] = list1[j + 1]
            list1[j + 1] = temp
        print(" ", list1)
    print("", list1)
print(list1)
