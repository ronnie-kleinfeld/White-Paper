import sqlite3
from pathlib import Path

movies = [
    {"id": 1, "title": "the matrix"},
    {"id": 2, "title": "terminator"},
    {"id": 3, "title": "notting hill"},
]
db = Path(
    "/Users/ronniekleinfeld/Dev/White papers/Python/_Playground/SQLite/db.sqlite3"
)
# print("INSERT")
# with sqlite3.connect(db) as connection:
#     command = "INSERT INTO Movies VALUES(?, ?)"
#     for movie in movies:
#         connection.execute(command, tuple(movie.values()))
#     connection.commit()

print("SELECT")  # iter rows
with sqlite3.connect(db) as connection:
    command = "SELECT * FROM Movies"
    cursor = connection.execute(command)
    for row in cursor:
        print(row)

print("SELECT")  # fetch all into list
with sqlite3.connect(db) as connection:
    command = "SELECT * FROM Movies"
    cursor = connection.execute(command)
    data = cursor.fetchall()
    print(data)
