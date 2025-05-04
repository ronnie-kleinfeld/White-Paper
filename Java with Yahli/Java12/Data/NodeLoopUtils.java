package Data;

import java.util.Stack;

public class NodeLoopUtils {

    public static <T> void iterateNodes(Node<T> head) {
        Node<T> current = head;
        while (current != null) {
            System.out.println(current.getValue());
            current = current.getNext();
        }
    }

    public static <T> T getFirstItem(Node<T> head) {
        return (head != null) ? head.getValue() : null;
    }

    public static <T> T getLastItem(Node<T> head) {
        if (head == null)
            return null;
        Node<T> current = head;
        while (current.getNext() != null) {
            current = current.getNext();
        }
        return current.getValue();
    }

    public static <T> Node<T> rotateLeft(Node<T> head) {
        if (head == null || head.getNext() == null)
            return head;
        Node<T> newHead = head.getNext();
        Node<T> current = head;
        while (current.getNext() != null) {
            current = current.getNext();
        }
        current.setNext(head);
        head.setNext(null);
        return newHead;
    }

    public static <T> Node<T> rotateRight(Node<T> head) {
        if (head == null || head.getNext() == null)
            return head;
        Node<T> prev = null, current = head;
        while (current.getNext() != null) {
            prev = current;
            current = current.getNext();
        }
        current.setNext(head);
        prev.setNext(null);
        return current;
    }

    public static <T> int getNodePosition(Node<T> head, T value) {
        int pos = 0;
        Node<T> current = head;
        while (current != null) {
            if (current.getValue().equals(value))
                return pos;
            current = current.getNext();
            pos++;
        }
        return -1;
    }

    public static <T> Node<T> getNodeByIndex(Node<T> head, int index) {
        int pos = 0;
        Node<T> current = head;
        while (current != null) {
            if (pos == index)
                return current;
            current = current.getNext();
            pos++;
        }
        return null;
    }

    public static <T> Node<T> insertAtHead(Node<T> head, T value) {
        return new Node<>(value, head);
    }

    public static <T> Node<T> insertAtTail(Node<T> head, T value) {
        Node<T> newNode = new Node<>(value);
        if (head == null)
            return newNode;
        Node<T> current = head;
        while (current.getNext() != null) {
            current = current.getNext();
        }
        current.setNext(newNode);
        return head;
    }

    public static <T> Node<T> insertAtPosition(Node<T> head, int index, T value) {
        if (index == 0)
            return insertAtHead(head, value);
        Node<T> current = head;
        int pos = 0;
        while (current != null && pos < index - 1) {
            current = current.getNext();
            pos++;
        }
        if (current != null) {
            Node<T> newNode = new Node<>(value, current.getNext());
            current.setNext(newNode);
        }
        return head;
    }

    public static <T> Node<T> deleteFirst(Node<T> head) {
        if (head == null)
            return null;
        return head.getNext();
    }

    public static <T> Node<T> deleteLast(Node<T> head) {
        if (head == null || head.getNext() == null)
            return null;
        Node<T> current = head;
        while (current.getNext().getNext() != null) {
            current = current.getNext();
        }
        current.setNext(null);
        return head;
    }

    public static <T> Node<T> deleteAtPosition(Node<T> head, int index) {
        if (head == null)
            return null;
        if (index == 0)
            return head.getNext();
        Node<T> current = head;
        int pos = 0;
        while (current.getNext() != null && pos < index - 1) {
            current = current.getNext();
            pos++;
        }
        if (current.getNext() != null) {
            current.setNext(current.getNext().getNext());
        }
        return head;
    }

    public static <T> Node<T> findMiddleNode(Node<T> head) {
        if (head == null)
            return null;
        Node<T> slow = head, fast = head;
        while (fast != null && fast.getNext() != null) {
            slow = slow.getNext();
            fast = fast.getNext().getNext();
        }
        return slow;
    }

    public static <T> Node<T> reverseList(Node<T> head) {
        Node<T> prev = null;
        Node<T> current = head;
        while (current != null) {
            Node<T> next = current.getNext();
            current.setNext(prev);
            prev = current;
            current = next;
        }
        return prev;
    }

    public static <T> void iterateReverse(Node<T> head) {
        Stack<T> stack = new Stack<>();
        Node<T> current = head;
        while (current != null) {
            stack.push(current.getValue());
            current = current.getNext();
        }
        while (!stack.isEmpty()) {
            System.out.println(stack.pop());
        }
    }

    public static <T> int countNodes(Node<T> head) {
        int count = 0;
        Node<T> current = head;
        while (current != null) {
            count++;
            current = current.getNext();
        }
        return count;
    }

    public static <T> boolean containsValue(Node<T> head, T value) {
        Node<T> current = head;
        while (current != null) {
            if (current.getValue().equals(value))
                return true;
            current = current.getNext();
        }
        return false;
    }

    public static <T> Node<T> copyList(Node<T> head) {
        if (head == null)
            return null;
        Node<T> newHead = new Node<>(head.getValue());
        Node<T> currentOld = head.getNext();
        Node<T> currentNew = newHead;
        while (currentOld != null) {
            currentNew.setNext(new Node<>(currentOld.getValue()));
            currentNew = currentNew.getNext();
            currentOld = currentOld.getNext();
        }
        return newHead;
    }

    public static <T> Node<T> mergeTwoLists(Node<T> l1, Node<T> l2) {
        if (l1 == null)
            return copyList(l2);
        if (l2 == null)
            return copyList(l1);

        Node<T> dummy = new Node<>(null);
        Node<T> current = dummy;

        while (l1 != null && l2 != null) {
            current.setNext(new Node<>(l1.getValue()));
            current = current.getNext();
            l1 = l1.getNext();

            current.setNext(new Node<>(l2.getValue()));
            current = current.getNext();
            l2 = l2.getNext();
        }

        while (l1 != null) {
            current.setNext(new Node<>(l1.getValue()));
            current = current.getNext();
            l1 = l1.getNext();
        }

        while (l2 != null) {
            current.setNext(new Node<>(l2.getValue()));
            current = current.getNext();
            l2 = l2.getNext();
        }

        return dummy.getNext();
    }
}