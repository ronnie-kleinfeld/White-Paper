import string

# strings
print("CTOR")
print("123")  # 123
print(str("123"))  # 123
print(str("Ronnie"))  # Ronnie
print("abc" + "123")  # abc123
print("Hi" * 4)  # HiHiHiHi

print("CASTING")
print(str((1, 2, 3)))  # tuple to [1, 2, 3]
print("".join(list("Ronnie")))  # list to Ronnie

print("LEN")
print(len("Ronnie"))  # 6

print("GETTER - LIKE STRING")
letters = "abcdef"
print(letters[0])  # a
print(letters[1:3])  # bc
print(letters[:3])  # abc
print(letters[3:])  # def
print(letters[:])  # abcdef
print(letters[-1])  # f
print(letters[-2:])  # ef
print(letters[:-2])  # abcd
print(letters[0:3:2])  # ac
print(letters[::2])  # ace
print(letters[::-1])  # fedcba
print(letters[::-2])  # fdb

print("SETTER")
# letters[0] = "a"  # error - cannot set a string

print("ITER")
names = "Ronnie"
for name in names:
    print(name)
for iter in enumerate(names):
    print(iter, iter[0], iter[1])  # iter = (0, 'R')
for index, name in enumerate(names):
    print(index, name)
for i in range(len(names)):
    print(i, names[i])

print("ASCII")
print(ord("A"))  # 65 - ascii code
print(chr(65))  # A - ascii char

print(string.ascii_letters)  # abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ
print(string.ascii_lowercase)  # abcdefghijklmnopqrstuvwxyz
print(string.ascii_uppercase)  # ABCDEFGHIJKLMNOPQRSTUVWXYZ
print(string.digits)  # 0123456789
print(string.punctuation)  #!"#$%&'()*+,-./:;<=>?@[\]^_`{|}~
print(string.hexdigits)  # 0123456789abcdefABCDEF

print("SEARCH")
"tho" in "Python"  # True
"tho" not in "Python"  # False

print("STRING")
print("  Hi  ".lstrip())  # Hi
print("  Hi  ".rstrip())  #   Hi
print("  Hi  ".strip())  # Hi

print("a b c".split())  # ['a', 'b', 'c']
print("a b c".split(" "))  # ['a', 'b', 'c']
print("a,b,c".split(","))  # ['a', 'b', 'c']

print("a b c d c f".count("c"))  # 2
print("a b c d c f".find("c"))  # 4

list = ["a", "b", "c"]
print(" ".join(list))  # a b c

str = "012345"
print(str[3])  # 3
print(str[2:5])  # 234
print(str[2:])  # 2345
print(str[:2])  # 01
print(str[-3])  # 3
print(str[-3:])  # 345
print(str[:-3])  # 012
