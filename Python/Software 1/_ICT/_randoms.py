import random

print(random.random())
print(random.randint(1, 10))
print(random.choice([0, 1, 1, 3, 5, 8, 13]))
print(random.choices([0, 1, 1, 3, 5, 8, 13], k=2))  # [0, 13]
password = random.choices("abcdefghijklmnopqrstuvwxyz", k=7)
print(password)  # ['g', 'w', 'z', 'n', 'm', 'a', 'o']
print("".join(password))  # gwznmao

numbers = [1, 2, 3, 4]
print(numbers)
random.shuffle(numbers)
print(numbers)
