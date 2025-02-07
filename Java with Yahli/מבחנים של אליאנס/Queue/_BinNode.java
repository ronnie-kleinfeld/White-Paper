public class _BinNode<T> {

    private _BinNode<T> left;
    private T value;
    private _BinNode<T> right;

    public _BinNode(_BinNode<T> left, T value, _BinNode<T> right) {

        this.left = left;
        this.value = value;
        this.right = right;
    }

    public _BinNode(T value) {

        this.value = value;
        this.right = null;
        this.left = null;

    }

    public _BinNode<T> getLeft() {

        return left;
    }

    public void setLeft(_BinNode<T> left) {

        this.left = left;
    }

    public T getValue() {

        return value;
    }

    public void setValue(T value) {

        this.value = value;
    }

    public _BinNode<T> getRight() {

        return right;
    }

    public void setRight(_BinNode<T> right) {

        this.right = right;
    }

    public boolean hasLeft() {

        return left != null;
    }

    public boolean hasRight() {

        return right != null;
    }
}