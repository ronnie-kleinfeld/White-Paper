print("QUEUES FIFO")
# implemented with a list

from collections import deque

queue = deque([])
queue.append(1)
queue.append(2)
queue.append(3)
print(queue)
print(queue.popleft())
print(queue)