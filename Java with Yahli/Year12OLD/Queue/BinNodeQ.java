public class BinNodeQ {
    public static void main(String[] args) {
        _BinNode<Integer> d = new _BinNode<>(4);
        _BinNode<Integer> c = new _BinNode<>(3);
        _BinNode<Integer> b = new _BinNode<>(2);
        _BinNode<Integer> a = new _BinNode<>(1);
        a.setLeft(b);
        a.setRight(d);
        b.setLeft(c);
        // Q9(root);
        System.out.println(Q19(a, 4));
    }

    public static Boolean Q19(_BinNode<Integer> t, int n) {
        if (n > 0) {
            if (Q19Count(t, n) == 1) {
                n--;
                return true;
            } else {
                return false;
            }
        }
        return true;
    }

    public static int Q19Count(_BinNode<Integer> t, Integer i) {
        if (t == null) {
            return 0;
        }

        if (t.getValue() == i) {
            return 1 + Q19Count(t.getLeft(), i) + Q19Count(t.getRight(), i);
        } else {
            return Q19Count(t.getLeft(), i) + Q19Count(t.getRight(), i);
        }
    }

    public static <T> void Q9(_BinNode<T> root) {
        if (root != null) {
            System.out.print(root.getValue() + " ");
            Q9(root.getLeft());
            Q9(root.getRight());
        }
    }

    public static <T> void Q10(_BinNode<T> root) {
        if (root != null) {
            if (!root.hasLeft() && !root.hasRight()) {
                System.out.println(root.getValue() + " ");
            }
            Q10(root.getLeft());
            Q10(root.getRight());
        }
    }
}