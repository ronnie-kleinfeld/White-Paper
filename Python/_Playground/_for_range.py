# range(start(inclusive), end(exclusive), step)
print(list(range(0)))  # list: [] - range: empty
print(list(range(1)))  # list: [0] - range: 0
print(list(range(5)))  # list: [0, 1, 2, 3, 4] - range: 0, 1, 2, 3, 4
print(list(range(0, 7, 2)))  # list: [0, 2, 4, 6] - range: 0, 2, 4, 6
print(list(range(7, 0, -2)))  # list: [7, 5, 3, 1] - range: 7, 5, 3, 1

# for
for i in range(2, 6):  # iter range
    print(i)  # 2 3 4 5
for s in "Ronnie":  # iter string
    print(s)  # R o n n i e

for i in [1, 3, 4, 7]:  # iter list
    print(i)  # 1 3 4 7

for i in range(0, 21, 2):
    print(i)  # 0 2 4 6 8 10 12 14 16 18 20
for i in range(0, 20):
    if i % 2 == 1:
        print(i)  # 1 3 5 7 9 11 13 15 17 19

# triangle
# x
# xx
# xxx
# xxxx
# xxxxx
for i in range(5):  # 0-4
    print("x" * (i + 1))
