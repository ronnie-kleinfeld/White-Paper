from pathlib import Path

# path
print("PATH")
print(
    Path("/Users/ronniekleinfeld/Dev/White papers/Python/_Playground/modules_packages")
)
print(Path())  # . - current folder
print(Path("monitor.py"))  # monitor.py

print(Path.home())  # /Users/ronniekleinfeld

path = Path("/Users/ronniekleinfeld/Pictures/Ronnie.png")
print(path.exists())  # True
print(path.is_file())  # True
print(path.is_dir())  # False
print(path.name)  # Ronnie.png
print(path.stem)  # Ronnie
print(path.suffix)  # .png
print(path.parent)  # /Users/ronniekleinfeld/Pictures
print(path.with_name("Irene.png"))  # /Users/ronniekleinfeld/Pictures/Irene.png
print(path.with_suffix(".txt"))  # /Users/ronniekleinfeld/Pictures/Ronnie.txt
print(path.absolute())  # /Users/ronniekleinfeld/Pictures/Ronnie.png

# directories
print("DIRECTORIES")
dir = Path("/Users/ronniekleinfeld/Music")
for p in dir.iterdir():
    print(p)

print([p for p in dir.iterdir() if p.is_dir()])
print([p for p in dir.iterdir() if p.is_file()])

print([p for p in dir.glob("**/*.txt")])

# files
print("FILES")
path = Path("/Users/ronniekleinfeld/Pictures/Ronnie.jpg")
print(path)
print(path.exists())
print(path.is_file())
print(path.stat())
print(path.stat().st_ctime)

print(path.read_bytes())

##############################################################################
# "r" - Read - Default value. Opens a file for reading, error if the file does not exist
# "a" - Append - Opens a file for appending, creates the file if it does not exist
# "w" - Write - Opens a file for writing, creates the file if it does not exist
# "x" - Create - Creates the specified file, returns an error if the file exists
# "+" - open for updating (reading and writing)

# "t" - Text - Default value. Text mode
# "b" - Binary - Binary mode (e.g. images)

# f = open("demofile.txt") is like f = open("demofile.txt", "rt")
##############################################################################

with open(path) as file:
    pass

file = open(path, "r")
buffer = file.read()
file.close()

import shutil

shutil.copy("source.txt", "target.txt")
