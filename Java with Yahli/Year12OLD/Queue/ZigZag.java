public class ZigZag {
    public static void main(String[] args) {
        _BinNode<Character> d = new _BinNode<>('a');
        _BinNode<Character> c = new _BinNode<>('a');
        _BinNode<Character> b = new _BinNode<>('b');
        _BinNode<Character> a = new _BinNode<>('a');
        _BinNode<Character> e = new _BinNode<>('g');
        _BinNode<Character> f = new _BinNode<>('a');
        _BinNode<Character> h = new _BinNode<>('b');
        _BinNode<Character> i = new _BinNode<>('a');
        a.setLeft(b);
        a.setRight(c);
        b.setLeft(d);
        b.setRight(e);
        c.setLeft(f);
        c.setRight(h);
        f.setLeft(i);
        // Q9(root);
        // printTree(a);
        // System.out.println();
        // System.out.println(isAllTreeEqualTo(a, 'a'));
        System.out.println(printTreeZigZag(a, "left", a.getValue()));
    }

    public static Boolean IsZigzag(_BinNode<Character> t) {
        return hasZigZagRoute(t, "left") || hasZigZagRoute(t, "right");
    }

    public static Boolean hasZigZagRoute(_BinNode<Character> t, String direction) {
        if (t != null) {
            if (direction.equals("left")) {
                return hasZigZagRoute(t.getLeft(), "right");
            } else {
                return hasZigZagRoute(t.getRight(), "left");
            }
        }
        return true;
    }

    public static void printTree(_BinNode<Character> t) {
        if (t != null) {
            System.out.print(t.getValue());
            printTree(t.getLeft());
            printTree(t.getRight());
        }
    }

    public static String printTreeZigZag(_BinNode<Character> t, String direction, Character value) {
        if (t != null) {
            System.out.println(t.getValue() + "-" + (t.getValue() == value));
            if (direction.equals("left")) {
                return printTreeZigZag(t.getLeft(), "right", value);
            } else {
                return printTreeZigZag(t.getRight(), "left", value);
            }
        }
        return "";
    }

    public static Boolean isAllTreeEqualTo(_BinNode<Character> t, Character value) {
        if (t != null) {
            if (t.getValue() != value)
                return false;
            return isAllTreeEqualTo(t.getLeft(), value) && isAllTreeEqualTo(t.getRight(), value);

        }
        return true;
    }
}
