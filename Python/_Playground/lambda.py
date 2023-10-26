print("LAMBDA")
items = [
    ("Product1", 10),
    ("Product3", 9),
    ("Product2", 12),
]
items.sort()
print(items)


def sort_item(item):
    return item[1]


items.sort(key=sort_item)
print(items)

items.sort(key=lambda item: item[1])
print(items)
items.sort(key=lambda item: item[1], reverse=True)
print(items)
