print("Monitor - time of execution")
from timeit import timeit

code = """
i = 5
print(i)
"""
print(timeit(code))

print("Monitor - size of object")
