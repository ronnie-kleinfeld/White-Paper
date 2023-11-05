def factorial(num):
    if num <= 1:
        return 1
    else:
        return num * factorial(num - 1)


print(factorial(0))
print(factorial(1))
print(factorial(2))
print(factorial(3))
print(factorial(4))
print(factorial(5))
print(factorial(6))


def fibonachi(n):
    if n == 0:
        return 0
    elif n == 1:
        return 1
    else:
        return fibonachi(n - 1) + fibonachi(n - 2)


for i in range(10):
    print(fibonachi(i))
