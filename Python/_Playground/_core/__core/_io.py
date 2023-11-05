# io - print / input
print("Hello")  # Hello
print("1", "2")  # 1 2
print("1", "2", end="\n")  # 1 2

first = "Ronnie"
last = "Kleinfeld"
print(f"My name is: {first} {last}")  # Ronnie Kleinfeld
print(f"My date of birth is: {15}/{6:2d}/{70}")  # 15/ 6/70
print(f"My date of birth is: {15}/{6:02d}/{70}")  # 15/06/70


name = input("What is your name:")

name, age = input("Enter name ane age")  # Ronnie 53
