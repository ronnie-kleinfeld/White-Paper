import threading
import time


threadLock = threading.Lock()

class SubThread(threading.Thread):
    def __init__(self, name, sleep):
        threading.Thread.__init__(self)
        self.name = name
        self.sleep = sleep

    def run(self):
        # threadLock.locked()
        print(
            f"Thread {self.name} sleeps at {time.strftime("%H:%M:%S", time.gmtime())} for {self.sleep} seconds"
        )
        # threadLock.release()
        time.sleep(self.sleep)
        print("Thread", self.name, "Execution Ends")
        
# Create thread objects
thread1 = SubThread("1st", 1)
thread2 = SubThread("2nd", 5)
thread3 = SubThread("3rd", 3)

# Start thread execution of run()
thread1.start()
thread2.start()
thread3.start()

print()

print(f"Thread {thread1.name} Alive : {thread1.is_alive()}")
print(f"Thread {thread2.name} Alive : {thread2.is_alive()}")
print(f"Thread {thread3.name} Alive : {thread3.is_alive()}")

print()

print("Main thread is live")
thread1.join()
print("Main thread is waiting for thread1")
thread2.join()
thread3.join()
print("End execution")
