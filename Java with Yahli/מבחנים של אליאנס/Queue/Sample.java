import java.util.LinkedList;
import java.util.Queue;

public class Sample {
    public static void main(String[] args) {
        // Create a Queue using LinkedList
        Queue<Integer> queue = new LinkedList<>();

        // Enqueue operation (add elements to the queue)
        queue.offer(10); // Adds 10 to the queue
        queue.offer(20);
        queue.offer(30);

        // Display the queue
        System.out.println("Queue: " + queue);

        // Peek operation (view the front element without removing it)
        System.out.println("Peek: " + queue.peek());

        // Dequeue operation (remove the front element)
        System.out.println("Dequeued: " + queue.poll()); // Removes 10
        System.out.println("Queue after dequeue: " + queue);

        // Check if the queue is empty
        System.out.println("Is the queue empty? " + queue.isEmpty());

        // Check the size of the queue
        System.out.println("Size of the queue: " + queue.size());
    }
}
