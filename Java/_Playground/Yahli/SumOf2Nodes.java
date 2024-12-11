public class SumOf2Nodes {
    public static void main(String[] args) {
        _Node<Integer> node1 = new _Node<Integer>(3);

        _Node<Integer> node2 = new _Node<Integer>(7);
        node1.setNext(node2);

        _Node<Integer> node3 = new _Node<Integer>(5);
        node2.setNext(node3);

        _Node<Integer> node4 = new _Node<Integer>(4);
        node3.setNext(node4);

        System.out.println(IsSumOf2Nodes(node1, 10));
    }

    public static boolean IsSumOf2Nodes(_Node<Integer> lst, int sum) {
        if (lst.getNext() == null) {
            return false;
        }

        if (equalToSum(lst.getNext(), lst.getValue(), sum)) {
            return true;
        }

        return IsSumOf2Nodes(lst.getNext(), sum);
    }

    public static boolean equalToSum(_Node<Integer> lst, int x, int sum) {
        while (lst != null) {
            if (x + lst.getValue() == sum) {
                return true;
            }
            lst = lst.getNext();
        }

        return false;
    }
}
