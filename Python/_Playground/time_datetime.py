import time
from datetime import datetime, timedelta

print(time.time())  # 1698000243.1147141 miliseconds since 1/1/1970


def send_emails():
    for i in range(10000):
        pass


start = time.time()
send_emails()
end = time.time()
print(end - start)


print(datetime.now())  # 2023-10-22 19:47:06.395300

dt = datetime(2023, 10, 7)
print(f"{dt.year}/{dt.month}")  # 2023/10

# https://docs.python.org/3/library/datetime.html#strftime-and-strptime-behavior
print(datetime.strptime("2023/10/09", "%Y/%m/%d"))  # 2023-10-09 00:00:00

print(datetime.fromtimestamp(time.time()))  # 2023-10-22 19:51:53.152551

delta = datetime.now() - dt
print(delta)  # 15 days, 20:03:51.801385
print(delta.days)  # 15
print(delta.total_seconds())  # 1368382.302604
