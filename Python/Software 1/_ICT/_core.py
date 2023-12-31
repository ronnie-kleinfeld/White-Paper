# string - imutable
# tuple - imutable
# list - mutable
# dictionary - mutable

print("VARIABLES")
type(1)  # int / numeric
type(1.1)  # float
type("")  # string
type(True)  # boolean - True | False
message = """Dear John,
I hope everything is goos

Regards,
Ronnie
"""

print("ASCII")
print(ord(" "))
print(ord("b"))
print(ord("B"))
# print(ord("Ba")) # error - can get only 1 character


x = y = 1
x, y = 1, 2

print("ADDRESS")
x = 1
print(id(x))

print("CAST")
print(int("15"))
print(float("15"))
print(bool("True"))  # Falsy - "" 0 None False
print(str("15"))

print(type("Ronnie"))  # <class 'str'>

print("SWAP")
x = 5
y = 7

x, y = y, x
