# dictionary
print("CTOR")
print({})  # {}
print({"x": 1, "y": 2})  # {'x': 1, 'y': 2}
dic = dict(x=1, y=2)
print(dic)  # {'x': 1, 'y': 2}

print("SETTER")
dic["x"] = 5
print(dic)  # {'x': 5, 'y': 2}
dic["z"] = 7
print(dic)  # {'x': 5, 'y': 2, 'z': 7}

print("GETTER")
# print(dic["a"])  # KeyError: 'a'
print(dic.get("a"))  # None
print("x" in dic)  # True

##############################################################################
print("KEYS and VALUES")
print(dic.keys())
print(dic.values())

##############################################################################
print("ITER")
dic = dict(a=1, b=2, c=3, d=4)
print("Keys: ", end=" ")
for item in dic.keys():
    print(item, end=", ")
print()

print("dic: ", end=" ")
for key in dic:
    print(key, dic[key], end=", ")
print()

print("Values: ", end=" ")
for item in dic.values():
    print(item, end=", ")
print()

print("Items: ", end=" ")
for item in dic.items():
    print(item, end=", ")
print()

print("Key, Value: ", end=" ")
for key, value in dic.items():
    print(key, value, end=", ")
print()

values = {x: x * 2 for x in range(5) if x % 2 == 0}
print(values)

print("DELETE")
del dic["a"]
print(dic)  # {'b': 2, 'c': 3, 'd': 4}
dic["y"] = None
print(dic)  # {'b': 2, 'c': 3, 'd': 4, 'y': None}
dic.clear()
print(dic)  # {}
