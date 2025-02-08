public class _Node<T> {
    private T value;
    private _Node<T> next;

    public _Node(T value) {
        this.value = value;
        this.next = null;
    }

    public _Node(T value, _Node<T> next) {
        this.value = value;
        this.next = next;
    }

    public T getValue() {
        return value;
    }

    public _Node<T> getNext() {
        return next;
    }

    public void setValue(T value) {
        this.value = value;
    }

    public void setNext(_Node<T> next) {
        this.next = next;
    }

    public String toString() {
        return "" + value;
    }
}
