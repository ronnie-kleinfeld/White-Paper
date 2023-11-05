print("SET")

numbers = [1, 1, 2, 3, 4]
uniques = set(numbers)
print(uniques)  # {1, 2, 3, 4}

second = {1, 2, "abc"}
print(second)  # {1, 2, 'abc'}

second.add(5)
print(second)  # {'abc', 1, 2, 5}

second.remove(5)
print(second)  # {'abc', 1, 2}


A = {1, 2, 3, 4, 5}
B = {4, 5, 6, 7}
print(A)  # {1, 2, 3, 4, 5}
print(B)  # {4, 5, 6, 7}
print(A | B)  # {1, 2, 3, 4, 5, 6, 7}
print(A & B)  # {4, 5}
print(A - B)  # {1, 2, 3}
print(A ^ B)  # {1, 2, 3, 6, 7}
if 1 in A:
    print("1 is in A")
