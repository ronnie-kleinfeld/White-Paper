customers = []
while True:
    more = input("Enter Customer (Yes/No) :")
    if more[0].upper() == "N":
        break
    name1, name2 = input("Enter Customer Name:").split()
    customers.append({"name1": name1, "name2": name2})

for customer in customers:
    print(customer["name1"], customer["name2"])
