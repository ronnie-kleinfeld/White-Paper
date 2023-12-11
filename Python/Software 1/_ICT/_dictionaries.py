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
for key in dic.keys():
    print(key, end=" ")
print()

for key in dic:
    print(key, dic[key], end=" ")
print()

for item in dic.items():
    print(item, end=" ")
print()

for key, value in dic.items():
    print(key, value, end=" ")
print()

values = {x: x * 2 for x in range(5)}
print(values)

print("DELETE")
del dic["x"]
print(dic)  # {'y': 2, 'z': 7}
dic["y"] = None
print(dic)  # {'y': None, 'z': 7}
dic.clear()
print(dic)  # {}
