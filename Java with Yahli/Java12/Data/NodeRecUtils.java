package Data;

public class NodeRecUtils {

    public static <T> void iterateNodes(Node<T> head) {
        if (head == null)
            return;
        System.out.println(head.getValue());
        iterateNodes(head.getNext());
    }

    public static <T> void iterateNodesReverse(Node<T> head) {
        if (head == null)
            return;
        iterateNodesReverse(head.getNext());
        System.out.println(head.getValue());
    }

    public static <T> T getFirstItem(Node<T> head) {
        return (head != null) ? head.getValue() : null;
    }

    public static <T> T getLastItem(Node<T> head) {
        if (head == null)
            return null;
        if (head.getNext() == null)
            return head.getValue();
        return getLastItem(head.getNext());
    }

    public static <T> Node<T> rotateLeft(Node<T> head) {
        if (head == null || head.getNext() == null)
            return head;
        Node<T> newHead = head.getNext();
        rotateLeftAttach(head, newHead);
        head.setNext(null);
        return newHead;
    }

    private static <T> void rotateLeftAttach(Node<T> oldHead, Node<T> current) {
        if (current.getNext() == null) {
            current.setNext(oldHead);
            return;
        }
        rotateLeftAttach(oldHead, current.getNext());
    }

    public static <T> Node<T> rotateRight(Node<T> head) {
        if (head == null || head.getNext() == null)
            return head;
        return rotateRightHelper(null, head);
    }

    private static <T> Node<T> rotateRightHelper(Node<T> prev, Node<T> current) {
        if (current.getNext() == null) {
            current.setNext(prev == null ? null : prev);
            if (prev != null)
                prev.setNext(null);
            return current;
        }
        Node<T> newHead = rotateRightHelper(current, current.getNext());
        if (prev != null)
            prev.setNext(null);
        return newHead;
    }

    public static <T> int getNodePosition(Node<T> head, T value) {
        return getNodePositionHelper(head, value, 0);
    }

    private static <T> int getNodePositionHelper(Node<T> node, T value, int pos) {
        if (node == null)
            return -1;
        if (node.getValue().equals(value))
            return pos;
        return getNodePositionHelper(node.getNext(), value, pos + 1);
    }

    public static <T> Node<T> getNodeByIndex(Node<T> head, int index) {
        return getNodeByIndexHelper(head, index, 0);
    }

    private static <T> Node<T> getNodeByIndexHelper(Node<T> node, int index, int currentIndex) {
        if (node == null)
            return null;
        if (currentIndex == index)
            return node;
        return getNodeByIndexHelper(node.getNext(), index, currentIndex + 1);
    }

    public static <T> Node<T> insertAtHead(Node<T> head, T value) {
        return new Node<>(value, head);
    }

    public static <T> Node<T> insertAtTail(Node<T> head, T value) {
        if (head == null)
            return new Node<>(value);
        head.setNext(insertAtTail(head.getNext(), value));
        return head;
    }

    public static <T> Node<T> insertAtPosition(Node<T> head, int index, T value) {
        if (index == 0)
            return insertAtHead(head, value);
        if (head == null)
            return null;
        head.setNext(insertAtPosition(head.getNext(), index - 1, value));
        return head;
    }

    public static <T> Node<T> deleteFirst(Node<T> head) {
        return (head != null) ? head.getNext() : null;
    }

    public static <T> Node<T> deleteLast(Node<T> head) {
        if (head == null || head.getNext() == null)
            return null;
        head.setNext(deleteLast(head.getNext()));
        return head;
    }

    public static <T> Node<T> deleteAtPosition(Node<T> head, int index) {
        if (head == null)
            return null;
        if (index == 0)
            return head.getNext();
        head.setNext(deleteAtPosition(head.getNext(), index - 1));
        return head;
    }

    public static <T> Node<T> findMiddleNode(Node<T> head) {
        int count = countNodes(head);
        return getNodeByIndex(head, count / 2);
    }

    public static <T> Node<T> reverseList(Node<T> head) {
        return reverseListHelper(head, null);
    }

    private static <T> Node<T> reverseListHelper(Node<T> current, Node<T> prev) {
        if (current == null)
            return prev;
        Node<T> next = current.getNext();
        current.setNext(prev);
        return reverseListHelper(next, current);
    }

    public static <T> void iterateReverse(Node<T> head) {
        if (head == null)
            return;
        iterateReverse(head.getNext());
        System.out.println(head.getValue());
    }

    public static <T> int countNodes(Node<T> head) {
        if (head == null)
            return 0;
        return 1 + countNodes(head.getNext());
    }

    public static <T> boolean containsValue(Node<T> head, T value) {
        if (head == null)
            return false;
        if (head.getValue().equals(value))
            return true;
        return containsValue(head.getNext(), value);
    }

    public static <T> Node<T> copyList(Node<T> head) {
        if (head == null)
            return null;
        return new Node<>(head.getValue(), copyList(head.getNext()));
    }

    public static <T> Node<T> mergeTwoLists(Node<T> l1, Node<T> l2) {
        if (l1 == null)
            return copyList(l2);
        if (l2 == null)
            return copyList(l1);
        Node<T> newNode = new Node<>(l1.getValue());
        newNode.setNext(new Node<>(l2.getValue()));
        newNode.getNext().setNext(mergeTwoLists(l1.getNext(), l2.getNext()));
        return newNode;
    }
}