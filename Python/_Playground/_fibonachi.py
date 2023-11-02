def fibonachi(i):
    if i == 0:
        return 0
    elif i == 1:
        return 1
    else:
        return fibonachi(i - 2) + fibonachi(i - 1)


print(fibonachi(0))
print(fibonachi(1))
print(fibonachi(2))
print(fibonachi(3))
print(fibonachi(4))
print(fibonachi(5))
print(fibonachi(6))
print(fibonachi(7))
print(fibonachi(10))
print(fibonachi(100))
# print(fibonachi(1000))
