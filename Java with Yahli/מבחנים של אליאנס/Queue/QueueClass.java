public class QueueClass {
    public static void main(String[] args) {
        print(newQueue());
        print(clone(newQueue()));
        print(move(newQueue()));

        System.out.println(found(newQueue(), 3));
        System.out.println(found(newQueue(), 4));
        System.out.println(found(newQueue(), 5));

        System.out.println(size(newQueue()));
    }

    public static _Queue<Integer> newQueue() {
        _Queue<Integer> q = new _Queue<Integer>();
        q.insert(3);
        q.insert(5);
        q.insert(7);
        q.insert(8);
        return q;
    }

    // clone 4
    public static _Queue<Integer> clone(_Queue<Integer> q1) {
        _Queue<Integer> copy = new _Queue<Integer>();
        _Queue<Integer> temp = new _Queue<Integer>();
        while (!q1.isEmpty()) {
            copy.insert(q1.head());
            temp.insert(q1.remove());
        }
        while (!temp.isEmpty()) {
            q1.insert(temp.remove());
        }
        return copy;
    }

    // print
    public static void print(_Queue<Integer> q1) {
        _Queue<Integer> copy = clone(q1);

        while (!copy.isEmpty()) {
            System.out.print(copy.remove() + ",");
        }
        System.out.println();
    }

    // move 5
    public static _Queue<Integer> move(_Queue<Integer> q1) {
        _Queue<Integer> copy = new _Queue<Integer>();
        while (!q1.isEmpty()) {
            copy.insert(q1.remove());
        }

        return copy;
    }

    // found 6
    public static boolean found(_Queue<Integer> q1, int x) {
        _Queue<Integer> copy = clone(q1);

        while (!copy.isEmpty()) {
            if (x == copy.remove()) {
                return true;
            }
        }

        return false;
    }

    // size 7
    public static int size(_Queue<Integer> q1) {
        q1.insert(null);

        return size(q1, 0);
    }

    public static int size(_Queue<Integer> q1, int counter) {
        if (q1.head() == null) {
            q1.remove();
            return counter;
        }

        q1.insert(q1.remove());

        return size(q1, counter++);
    }
}
