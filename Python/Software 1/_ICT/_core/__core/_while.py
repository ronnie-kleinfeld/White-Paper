# while
num = 0
while num < 5:  # 1 2 3 4 5
    num += 1
    print(num, end=" ")
print()

num = 0
while num < 5:  # 1 2
    num += 1
    if num == 3:
        break
    print(num, end=" ")
print()

num = 0
while num < 5:  # 1 2 4 5
    num += 1
    if num == 3:
        continue
    print(num, end=" ")
print()

import math

height = 9
i = 1
while i <= height:
    print(" " * math.floor(height - i), end="")
    print("*" * (i * 2 - 1))
    i = i + 1
print(" " * math.floor(height - 1), end="*\n")
#         *
#        ***
#       *****
#      *******
#     *********
#    ***********
#   *************
#  ***************
# *****************
#         *
