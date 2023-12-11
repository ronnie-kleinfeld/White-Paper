# io - print
print("Hello")  # Hello
print("1" + "2")  # 12 - no space between
print("1", "2")  # 1 2 - space between
print("1", "2", end="\n")  # 1 2 - end default is \n

first = "Ronnie"
last = "Kleinfeld"
print(f"My name is: {first} {last}")  # Ronnie Kleinfeld
##############################################################################
print(f"My date of birth is: {15}/{6:2d}/{70}")  # 15/ 6/70
print(f"My date of birth is: {15}/{6:02d}/{70}")  # 15/06/70
##############################################################################
val = 12.335336
print(f"{val:.2f}")  # 12.34
print(f"{val:.5f}")  # 12.33534
##############################################################################
s1 = "a"
s2 = "ab"
print(f"{s1:>4}")  #   a
print(f"{s2:>4}")  #  ab
##############################################################################
name = "Peter"
age = 23
print("%s is %d years old" % (name, age))  # Peter is 23 years old
print("{} is {} years old".format(name, age))  # Peter is 23 years old
print(f"{name} is {age} years old")  # Peter is 23 years old
##############################################################################

i = 5
print("i=" + str(i))  # print take only strings


# io - input
name = input("What is your name:")

name, age = input("Enter name ane age")  # Ronnie 53
age = int(age)
