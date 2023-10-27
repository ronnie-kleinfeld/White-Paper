try:
    pass
except:
    pass
else:
    pass
finally:
    pass

# IndexError
# ModuleNotFoundError
# KeyError
# ImportErrorStopIteration
# TypeError
# ValueError
# NameError

try:
    n = 100 / 0
    n = int("A")
except (ZeroDivisionError, IndexError) as ex:
    print("value error except")
    print(ex)
except ValueError as ex:
    # on except
    print("value error except")
    print(ex)
except BaseException as ex:
    print("generic except")
    print(ex)
else:
    # if no except
    print("else")
finally:
    # anyway
    print("finally")

# like c# using
try:
    with open("app.py") as file:
        print("File opened")
except:
    print("except")


raise ValueError()
raise ValueError("Age can not be 0 or less")


# custom error
class InvalidOperationError(Exception):
    def __init__(self, *args: object, **kwargs) -> None:
        Exception.__init__(*args, *args, **kwargs)


raise InvalidOperationError("message")
