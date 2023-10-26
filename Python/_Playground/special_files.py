from pathlib import Path
from zipfile import ZipFile

print("ZIP")
dir = Path("/Users/ronniekleinfeld/Music")
with ZipFile("/Users/ronniekleinfeld/Music/files.zip", "w") as zip:
    for path in Path(dir).rglob("*.txt"):
        zip.write(path)

with ZipFile("/Users/ronniekleinfeld/Music/files.zip") as zip:
    print(zip.namelist())

print("CSV")
import csv

with open("special_files.csv", "w") as file:
    writer = csv.writer(file)
    writer.writerow(["trans", "product"])
    writer.writerow([1000, 1])
    writer.writerow([1001, 15])

with open("special_files.csv") as file:
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
