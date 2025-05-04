package Data;

public class QueueRecUtils {

    public static <T> void iterateNodes(Queue<T> queue) {
        Queue<T> temp = new Queue<>();
        while (!queue.isEmpty()) {
            T val = queue.remove();
            System.out.println(val);
            temp.insert(val);
        }
        while (!temp.isEmpty()) {
            queue.insert(temp.remove());
        }
    }

    public static <T> T getFirstItem(Queue<T> queue) {
        return queue.head();
    }

    public static <T> T getLastItem(Queue<T> queue) {
        T last = null;
        Queue<T> temp = new Queue<>();
        while (!queue.isEmpty()) {
            last = queue.remove();
            temp.insert(last);
        }
        while (!temp.isEmpty()) {
            queue.insert(temp.remove());
        }
        return last;
    }

    public static <T> void rotateLeft(Queue<T> queue) {
        if (queue.isEmpty())
            return;
        T first = queue.remove();
        queue.insert(first);
    }

    public static <T> void rotateRight(Queue<T> queue) {
        if (queue.isEmpty())
            return;
        Queue<T> temp = new Queue<>();
        T last = null;
        while (!queue.isEmpty()) {
            last = queue.remove();
            if (!queue.isEmpty())
                temp.insert(last);
        }
        queue.insert(last);
        while (!temp.isEmpty()) {
            queue.insert(temp.remove());
        }
    }

    public static <T> int getNodePosition(Queue<T> queue, T value) {
        int pos = 0;
        boolean found = false;
        Queue<T> temp = new Queue<>();
        while (!queue.isEmpty()) {
            T val = queue.remove();
            if (!found && val.equals(value))
                found = true;
            if (!found)
                pos++;
            temp.insert(val);
        }
        while (!temp.isEmpty()) {
            queue.insert(temp.remove());
        }
        return found ? pos : -1;
    }

    public static <T> T getNodeByIndex(Queue<T> queue, int index) {
        int pos = 0;
        T result = null;
        Queue<T> temp = new Queue<>();
        while (!queue.isEmpty()) {
            T val = queue.remove();
            if (pos == index)
                result = val;
            pos++;
            temp.insert(val);
        }
        while (!temp.isEmpty()) {
            queue.insert(temp.remove());
        }
        return result;
    }

    public static <T> void insertAtHead(Queue<T> queue, T x) {
        Queue<T> temp = new Queue<>();
        temp.insert(x);
        while (!queue.isEmpty()) {
            temp.insert(queue.remove());
        }
        while (!temp.isEmpty()) {
            queue.insert(temp.remove());
        }
    }

    public static <T> void insertAtTail(Queue<T> queue, T x) {
        queue.insert(x);
    }

    public static <T> void insertAtPosition(Queue<T> queue, T x, int position) {
        int pos = 0;
        Queue<T> temp = new Queue<>();
        boolean inserted = false;
        while (!queue.isEmpty()) {
            if (pos == position) {
                temp.insert(x);
                inserted = true;
            }
            temp.insert(queue.remove());
            pos++;
        }
        if (!inserted) { // insert at end if position >= size
            temp.insert(x);
        }
        while (!temp.isEmpty()) {
            queue.insert(temp.remove());
        }
    }

    public static <T> void deleteFirst(Queue<T> queue) {
        if (!queue.isEmpty()) {
            queue.remove();
        }
    }

    public static <T> void deleteLast(Queue<T> queue) {
        Queue<T> temp = new Queue<>();
        T last = null;
        while (!queue.isEmpty()) {
            last = queue.remove();
            if (!queue.isEmpty())
                temp.insert(last);
        }
        while (!temp.isEmpty()) {
            queue.insert(temp.remove());
        }
    }

    public static <T> void deleteAtPosition(Queue<T> queue, int position) {
        int pos = 0;
        Queue<T> temp = new Queue<>();
        while (!queue.isEmpty()) {
            T val = queue.remove();
            if (pos != position) {
                temp.insert(val);
            }
            pos++;
        }
        while (!temp.isEmpty()) {
            queue.insert(temp.remove());
        }
    }

    public static <T> T findMiddleNode(Queue<T> queue) {
        int count = 0;
        Queue<T> temp = new Queue<>();
        while (!queue.isEmpty()) {
            temp.insert(queue.remove());
            count++;
        }
        int mid = count / 2;
        T midValue = null;
        count = 0;
        while (!temp.isEmpty()) {
            T val = temp.remove();
            if (count == mid)
                midValue = val;
            queue.insert(val);
            count++;
        }
        return midValue;
    }

    public static <T> void reverseList(Queue<T> queue) {
        Queue<T> reversed = new Queue<>();
        while (!queue.isEmpty()) {
            T val = queue.remove();
            Queue<T> temp = new Queue<>();
            temp.insert(val);
            while (!reversed.isEmpty()) {
                temp.insert(reversed.remove());
            }
            while (!temp.isEmpty()) {
                reversed.insert(temp.remove());
            }
        }
        while (!reversed.isEmpty()) {
            queue.insert(reversed.remove());
        }
    }

    public static <T> void iterateReverse(Queue<T> queue) {
        Queue<T> reversed = new Queue<>();
        while (!queue.isEmpty()) {
            T val = queue.remove();
            Queue<T> temp = new Queue<>();
            temp.insert(val);
            while (!reversed.isEmpty()) {
                temp.insert(reversed.remove());
            }
            while (!temp.isEmpty()) {
                reversed.insert(temp.remove());
            }
        }
        while (!reversed.isEmpty()) {
            T val = reversed.remove();
            System.out.println(val);
            queue.insert(val);
        }
    }

    public static <T> int countNodes(Queue<T> queue) {
        int count = 0;
        Queue<T> temp = new Queue<>();
        while (!queue.isEmpty()) {
            temp.insert(queue.remove());
            count++;
        }
        while (!temp.isEmpty()) {
            queue.insert(temp.remove());
        }
        return count;
    }

    public static <T> boolean containsValue(Queue<T> queue, T value) {
        boolean found = false;
        Queue<T> temp = new Queue<>();
        while (!queue.isEmpty()) {
            T val = queue.remove();
            if (val.equals(value))
                found = true;
            temp.insert(val);
        }
        while (!temp.isEmpty()) {
            queue.insert(temp.remove());
        }
        return found;
    }

    public static <T> Queue<T> copyList(Queue<T> queue) {
        Queue<T> copy = new Queue<>();
        Queue<T> temp = new Queue<>();
        while (!queue.isEmpty()) {
            T val = queue.remove();
            copy.insert(val);
            temp.insert(val);
        }
        while (!temp.isEmpty()) {
            queue.insert(temp.remove());
        }
        return copy;
    }

    public static <T> void mergeTwoLists(Queue<T> queue, Queue<T> other) {
        while (!other.isEmpty()) {
            queue.insert(other.remove());
        }
    }
}
