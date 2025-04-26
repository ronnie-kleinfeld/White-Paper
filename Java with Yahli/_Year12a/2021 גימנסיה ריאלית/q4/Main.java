import Queue.Queue;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Queue<Customer> fullQueue = new Queue<>();
        fullQueue.Insert(new Customer("רוני", "001"));
        fullQueue.Insert(new Customer("אסף", "002"));
        fullQueue.Insert(new Customer("יאיר", "003"));
        fullQueue.Insert(new Customer("לבנת", "004"));
        fullQueue.Insert(new Customer("שלמה", "005"));
        fullQueue.Insert(new Customer("זני", "006"));
        fullQueue.Insert(new Customer("שלומית", "007"));
        fullQueue.Insert(new Customer("גל", "008"));
        fullQueue.Insert(new Customer("ילך", "009"));

        List<Queue<Customer>> resultQueues = splitQueue(fullQueue, 2);

        int teller = 1;
        for (Queue<Customer> q : resultQueues) {
            System.out.println("Teller " + teller++ + " queue:");
            while (!q.IsEmpty()) {
                System.out.println("  " + q.Remove());
            }
            System.out.println();
        }
    }

    public static List<Queue<Customer>> splitQueue(Queue<Customer> original, int numTellers) {
        List<Queue<Customer>> queues = new ArrayList<>();
        for (int i = 0; i < numTellers; i++) {
            queues.add(new Queue<>());
        }

        int i = 0;
        while (!original.IsEmpty()) {
            queues.get(i % numTellers).Insert(original.Remove());
            i++;
        }

        return queues;
    }
}
