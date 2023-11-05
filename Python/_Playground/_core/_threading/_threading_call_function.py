import threading
import time
import random


# create 10 threads that sleep for random seconds
def execute_thread(i):
    start = time.gmtime()
    print(f"Thread {i} sleeps at {time.strftime("%H:%M:%S", start)}")
    rand_sleep_time = random.randint(1, 7)
    time.sleep(rand_sleep_time)
    print(f"Thread {i} sleeping {time.strftime("%H:%M:%S", start)} {rand_sleep_time} {time.strftime("%H:%M:%S", time.gmtime())}")
    print("Active Threads :", threading.activeCount())


for i in range(10):
    thread = threading.Thread(target=execute_thread, args=(i,))
    thread.start()
    print("Active Threads :", threading.activeCount())
    print("Thread Objects :", threading.enumerate())
