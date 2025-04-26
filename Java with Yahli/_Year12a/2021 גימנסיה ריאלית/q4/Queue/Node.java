package Queue;

public class Node<T> {
    private T info;
    private Node<T> next;

    public Node(T info) {
        this.info = info;
        this.next = null;
    }

    public T GetInfo() {
        return info;
    }

    public Node<T> GetNext() {
        return next;
    }

    public void SetNext(Node<T> next) {
        this.next = next;
    }
}
