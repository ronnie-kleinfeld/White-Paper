import threading
import time
import random


# create 10 threads that sleep for random seconds
def execute_thread(i):
    start = time.gmtime()
    threadLock.acquire()
    print(f"Thread {i+1} sleeps at {time.strftime("%H:%M:%S", start)}")
    threadLock.release()
    rand_sleep_time = random.randint(1, 10)
    time.sleep(rand_sleep_time)
    threadLock.acquire()
    print(f"Thread {i+1} slept for {rand_sleep_time} seconds {time.strftime("%H:%M:%S", start)}-{time.strftime("%H:%M:%S", time.gmtime())} {threading.active_count()-2} threads left alive")
    # print("Remaining active threads :", threading.active_count())
    threadLock.release()

threadLock = threading.Lock()

for i in range(9):
    thread = threading.Thread(target=execute_thread, args=(i,))
    thread.start()
    # print("Active Threads :", threading.activeCount())
    # print("Thread Objects :", threading.enumerate())
