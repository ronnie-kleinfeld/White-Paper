import threading
import time


class SubThread(threading.Thread):
    def __init__(self, name, sleep):
        threading.Thread.__init__(self)
        self.name = name
        self.sleep = sleep

    def run(self):
        print(
            f"Thread {self.name} sleeps at {time.strftime("%H:%M:%S", time.gmtime())} for {self.sleep} seconds"
        )
        time.sleep(self.sleep)
        print("Thread", self.name, "Execution Ends")
        
# Create thread objects
thread1 = SubThread("1st", 1)
thread2 = SubThread("2nd", 10)
thread3 = SubThread("3rd", 5)

# Start thread execution of run()
thread1.start()
thread2.start()
thread3.start()

# Check if thread is alive
print("Thread 1 Alive :", thread1.is_alive())
print("Thread 2 Alive :", thread2.is_alive())
print("Thread 3 Alive :", thread3.is_alive())

# Get thread name
print("Thread 1 Name :", thread1.name)
print("Thread 2 Name :", thread2.name)
print("Thread 3 Name :", thread3.name)

# Wait for threads to exit
print("Execution Waiting 1")
thread1.join()
print("Execution Waiting 2")
thread2.join()
print("Execution Waiting 3")
thread3.join()
print("Execution Ends")
