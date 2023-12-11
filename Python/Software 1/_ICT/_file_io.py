from pathlib import Path

print("CSV")
import csv

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

with open("_special_files.csv", "w") as file:
    writer = csv.writer(file)
    writer.writerow(["trans", "product"])
    writer.writerow([1000, 1])
    writer.writerow([1001, 15])

with open("_special_files.csv") as file:
    reader = csv.reader(file)
    # print(reader)
    # print(list(reader))  # [['trans', 'product'], ['1000', '1'], ['1001', '15']]
    for row in reader:
        print(row[0], row[1])

print("JSON")
import json

data1 = [
    {"id": 1, "title": "the matrix"},
    {"id": 2, "title": "terminator"},
]
print(data1)  # [{'id': 1, 'title': 'the matrix'}, {'id': 2, 'title': 'terminator'}]
print(data1[0]["title"])  # the matrix

# to string
str = json.dumps(data1)
print(str)  # [{'id': 1, 'title': 'the matrix'}, {'id': 2, 'title': 'terminator'}]

# to data
data2 = json.loads(str)
print(data2)  # [{'id': 1, 'title': 'the matrix'}, {'id': 2, 'title': 'terminator'}]
