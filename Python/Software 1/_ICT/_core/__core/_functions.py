# return tuple
def multiply_divide(num_1, num_2):
    return (num_1 * num_2), (num_1 / num_2)


multi, divide = multiply_divide(4, 2)
print(multi, divide)  # 8 2.0


# default arg value
def do_something(first_name, last_name=".."):
    return first_name + " " + last_name


print(do_something("Ronnie", "Kleinfeld"))
print(do_something("Ronnie", last_name="Kleinfeld"))
print(do_something(last_name="Kleinfeld", first_name="Ronnie"))
print(do_something("Ronnie"))


# pass list of arg
def multiply(*numbers):
    for number in numbers:
        print(number, end=" ")


multiply(2, 3, 4, 5)
print()


# pass dictionary of key=value
def save_user(**user):
    print(user)  # {'id': 1, 'name': 'Ronnie', 'age': 25}


save_user(id=1, name="Ronnie", age=25)
