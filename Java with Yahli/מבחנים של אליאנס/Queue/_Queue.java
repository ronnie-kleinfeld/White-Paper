public class _Queue<T> {
    private _Node<T> first;
    private _Node<T> last;

    public _Queue() {
        this.first = null;
        this.last = null;
    }

    public void insert(T x) {
        _Node<T> tmp = new _Node<T>(x);
        if (first == null) {
            first = tmp;
        } else {
            last.setNext(tmp);
        }
        last = tmp;
    }

    public T remove() {
        T x = first.getValue();
        first = first.getNext();
        if (first == null)
            last = null;
        return x;
    }

    public T head() {
        return first.getValue();
    }

    public boolean isEmpty() {
        return (first == null);
    }

    public String toString() {
        String str = "[";
        _Node<T> pos = this.first;
        while (pos != null) {
            str = str + pos.getValue().toString();
            if (pos.getNext() != null)
                str = str + ",";
            pos = pos.getNext();
        }
        str = str + "]";
        return str;
    }
}