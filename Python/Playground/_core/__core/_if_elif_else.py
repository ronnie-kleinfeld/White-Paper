# if elif else
num1, operator, num2 = input("Enter Calculation:").split()

num1 = int(num1)
num2 = int(num2)

if operator == "+":
    result = num1 + num2
elif operator == "-":
    result = num1 - num2
elif operator == "*":
    result = num1 * num2
elif operator == "/":
    result = num1 / num2
else:
    result = "Error"

print(f"{num1} {operator} {num2} = {result}")


# logical and or not
age = int(input("Enter age:"))
if age < 5:
    print("Too young for School")
elif age == 5:
    print("Go to Kindergarten")
elif (age >= 6) and (age <= 17):
    print(f"Go to Grade {age - 5}")
else:
    print("Go to College")


# ternary
value = "true" if True else "false"
print(value)
