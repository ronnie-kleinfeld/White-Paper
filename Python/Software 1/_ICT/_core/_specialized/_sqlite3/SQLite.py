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
# with sqlite3.connect(db) as con:
#     cmd = "INSERT INTO Movies VALUES(?, ?)"
#     for movie in movies:
#         con.execute(cmd, tuple(movie.values()))
#     con.commit()

print("SELECT")  # iter rows
with sqlite3.connect(db) as con:
    cmd = "SELECT * FROM Movies"
    cursor = con.execute(cmd)
    for row in cursor:
        print(row)

print("SELECT")  # fetch all into list
with sqlite3.connect(db) as con:
    cmd = "SELECT * FROM Movies"
    cursor = con.execute(cmd)
    data = cursor.fetchall()
    print(data)
