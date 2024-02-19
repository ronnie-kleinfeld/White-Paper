money = int(input("Enter amount:"))
interest = float(input("Enter interset:"))

for i in range(10):
    print(money, end=" ")
    print(money * (interest / 100), end=" ")
    print(money + money * (interest / 100))
    money = money + money * (interest / 100)
    # print(money * (interest / 100), money)
