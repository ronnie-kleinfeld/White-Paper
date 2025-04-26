package Data;

public class NodeUtils {
    public static <T> void iterateNodes(Node<T> head) {
        Node<T> current = head;
        while (current != null) {
            System.out.println(current.GetInfo());
            current = current.GetNext();
        }
    }

    public static <T> T getFirstItem(Node<T> head) {
        return (head != null) ? head.GetInfo() : null;
    }

    public static <T> T getLastItem(Node<T> head) {
        if (head == null)
            return null;
        Node<T> current = head;
        while (current.GetNext() != null) {
            current = current.GetNext();
        }
        return current.GetInfo();
    }

    public static <T> Node<T> rotateLeft(Node<T> head) {
        if (head == null || head.GetNext() == null)
            return head;
        Node<T> newHead = head.GetNext();
        Node<T> current = head;
        while (current.GetNext() != null) {
            current = current.GetNext();
        }
        current.SetNext(head);
        head.SetNext(null);
        return newHead;
    }

    public static <T> Node<T> rotateRight(Node<T> head) {
        if (head == null || head.GetNext() == null)
            return head;
        Node<T> prev = null, current = head;
        while (current.GetNext() != null) {
            prev = current;
            current = current.GetNext();
        }
        prev.SetNext(null);
        current.SetNext(head);
        return current;
    }

    public static <T> int getNodePosition(Node<T> head, T value) {
        int pos = 0;
        Node<T> current = head;
        while (current != null) {
            if (current.GetInfo().equals(value))
                return pos;
            current = current.GetNext();
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
            current = current.GetNext();
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
        while (current.GetNext() != null) {
            current = current.GetNext();
        }
        current.SetNext(newNode);
        return head;
    }

    public static <T> Node<T> insertAtPosition(Node<T> head, int index, T value) {
        if (index == 0)
            return insertAtHead(head, value);
        Node<T> current = head;
        int pos = 0;
        while (current != null && pos < index - 1) {
            current = current.GetNext();
            pos++;
        }
        if (current != null) {
            Node<T> newNode = new Node<>(value, current.GetNext());
            current.SetNext(newNode);
        }
        return head;
    }

    public static <T> Node<T> deleteFirst(Node<T> head) {
        if (head == null)
            return null;
        return head.GetNext();
    }

    public static <T> Node<T> deleteLast(Node<T> head) {
        if (head == null || head.GetNext() == null)
            return null;
        Node<T> current = head;
        while (current.GetNext().GetNext() != null) {
            current = current.GetNext();
        }
        current.SetNext(null);
        return head;
    }

    public static <T> Node<T> deleteAtPosition(Node<T> head, int index) {
        if (head == null)
            return null;
        if (index == 0)
            return head.GetNext();
        Node<T> current = head;
        int pos = 0;
        while (current.GetNext() != null && pos < index - 1) {
            current = current.GetNext();
            pos++;
        }
        if (current.GetNext() != null) {
            current.SetNext(current.GetNext().GetNext());
        }
        return head;
    }

    public static <T> Node<T> findMiddleNode(Node<T> head) {
        if (head == null)
            return null;
        Node<T> slow = head, fast = head;
        while (fast != null && fast.GetNext() != null) {
            slow = slow.GetNext();
            fast = fast.GetNext().GetNext();
        }
        return slow;
    }

    public static <T> Node<T> reverseList(Node<T> head) {
        Node<T> prev = null;
        Node<T> current = head;
        while (current != null) {
            Node<T> next = current.GetNext();
            current.SetNext(prev);
            prev = current;
            current = next;
        }
        return prev;
    }

    public static <T> int countNodes(Node<T> head) {
        int count = 0;
        Node<T> current = head;
        while (current != null) {
            count++;
            current = current.GetNext();
        }
        return count;
    }

    public static <T> boolean containsValue(Node<T> head, T value) {
        Node<T> current = head;
        while (current != null) {
            if (current.GetInfo().equals(value))
                return true;
            current = current.GetNext();
        }
        return false;
    }

    public static <T> Node<T> copyList(Node<T> head) {
        if (head == null)
            return null;
        Node<T> newHead = new Node<>(head.GetInfo());
        Node<T> currentOld = head.GetNext();
        Node<T> currentNew = newHead;
        while (currentOld != null) {
            currentNew.SetNext(new Node<>(currentOld.GetInfo()));
            currentOld = currentOld.GetNext();
            currentNew = currentNew.GetNext();
        }
        return newHead;
    }

    public static <T> Node<T> mergeTwoLists(Node<T> l1, Node<T> l2) {
        if (l1 == null)
            return l2;
        if (l2 == null)
            return l1;

        Node<T> dummy = new Node<>(null);
        Node<T> current = dummy;

        while (l1 != null && l2 != null) {
            current.SetNext(l1);
            l1 = l1.GetNext();
            current = current.GetNext();

            current.SetNext(l2);
            l2 = l2.GetNext();
            current = current.GetNext();
        }

        if (l1 != null)
            current.SetNext(l1);
        if (l2 != null)
            current.SetNext(l2);

        return dummy.GetNext();
    }
}
