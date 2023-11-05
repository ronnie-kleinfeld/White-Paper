from my_package.module import calc_tax
import my_package.module as module
import sys

# import search directories
print(sys.path)
# ['/Users/ronniekleinfeld/Dev/White papers/Python/_Playground',
# '/Library/Frameworks/Python.framework/Versions/3.12/lib/python312.zip',
# '/Library/Frameworks/Python.framework/Versions/3.12/lib/python3.12',
# '/Library/Frameworks/Python.framework/Versions/3.12/lib/python3.12/lib-dynload',
# '/Library/Frameworks/Python.framework/Versions/3.12/lib/python3.12/site-packages']

calc_tax()
module.calc_shipping()

print(dir(module))  # ['__builtins__', '__cached__', '__doc__',
# '__file__', '__loader__', '__name__', '__package__', '__spec__',
# 'calc_shipping', 'calc_tax']

print(module.__name__)  # my_package.module
print(module.__package__)  # my_package
print(
    module.__file__
)  # /Users/ronniekleinfeld/Dev/White papers/Python/_Playground/modules_packages/my_package/module.py
