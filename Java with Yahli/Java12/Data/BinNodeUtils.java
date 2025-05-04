package Data;

import java.util.*;

public class BinNodeUtils {

    // 1. Iterate all nodes (in-order traversal)
    public static <T> void iterateNodes(BinNode<T> node) {
        if (node == null)
            return;
        iterateNodes(node.getLeft());
        System.out.println(node.getValue());
        iterateNodes(node.getRight());
    }

    // 2. Get first item (leftmost)
    public static <T> T getFirstItem(BinNode<T> node) {
        if (node == null)
            return null;
        while (node.hasLeft())
            node = node.getLeft();
        return node.getValue();
    }

    // 3. Get last item (rightmost)
    public static <T> T getLastItem(BinNode<T> node) {
        if (node == null)
            return null;
        while (node.hasRight())
            node = node.getRight();
        return node.getValue();
    }

    // 4. Rotate left (basic AVL style)
    public static <T> BinNode<T> rotateLeft(BinNode<T> node) {
        if (node == null || !node.hasRight())
            return node;
        BinNode<T> newRoot = node.getRight();
        node.setRight(newRoot.getLeft());
        newRoot.setLeft(node);
        return newRoot;
    }

    // 5. Rotate right
    public static <T> BinNode<T> rotateRight(BinNode<T> node) {
        if (node == null || !node.hasLeft())
            return node;
        BinNode<T> newRoot = node.getLeft();
        node.setLeft(newRoot.getRight());
        newRoot.setRight(node);
        return newRoot;
    }

    // 6. Get node position (in-order index)
    public static <T> int getNodePosition(BinNode<T> root, T value) {
        List<T> list = new ArrayList<>();
        inOrderToList(root, list);
        return list.indexOf(value);
    }

    private static <T> void inOrderToList(BinNode<T> node, List<T> list) {
        if (node == null)
            return;
        inOrderToList(node.getLeft(), list);
        list.add(node.getValue());
        inOrderToList(node.getRight(), list);
    }

    // 7. Get node by index (in-order)
    public static <T> BinNode<T> getNodeByIndex(BinNode<T> root, int index) {
        List<BinNode<T>> nodes = new ArrayList<>();
        inOrderNodes(root, nodes);
        return (index >= 0 && index < nodes.size()) ? nodes.get(index) : null;
    }

    private static <T> void inOrderNodes(BinNode<T> node, List<BinNode<T>> nodes) {
        if (node == null)
            return;
        inOrderNodes(node.getLeft(), nodes);
        nodes.add(node);
        inOrderNodes(node.getRight(), nodes);
    }

    // 8. Insert at head (insert leftmost)
    public static <T> BinNode<T> insertAtHead(BinNode<T> root, T value) {
        if (root == null)
            return new BinNode<>(value);
        BinNode<T> current = root;
        while (current.hasLeft())
            current = current.getLeft();
        current.setLeft(new BinNode<>(value));
        return root;
    }

    // 9. Insert at tail (insert rightmost)
    public static <T> BinNode<T> insertAtTail(BinNode<T> root, T value) {
        if (root == null)
            return new BinNode<>(value);
        BinNode<T> current = root;
        while (current.hasRight())
            current = current.getRight();
        current.setRight(new BinNode<>(value));
        return root;
    }

    // 10. Insert at position (by in-order index)
    public static <T> BinNode<T> insertAtPosition(BinNode<T> root, T value, int index) {
        List<T> list = new ArrayList<>();
        inOrderToList(root, list);
        list.add(index, value);
        return buildBalancedTree(list, 0, list.size() - 1);
    }

    private static <T> BinNode<T> buildBalancedTree(List<T> list, int start, int end) {
        if (start > end)
            return null;
        int mid = (start + end) / 2;
        BinNode<T> node = new BinNode<>(list.get(mid));
        node.setLeft(buildBalancedTree(list, start, mid - 1));
        node.setRight(buildBalancedTree(list, mid + 1, end));
        return node;
    }

    // 11. Delete first (delete leftmost)
    public static <T> BinNode<T> deleteFirst(BinNode<T> root) {
        if (root == null)
            return null;
        if (!root.hasLeft())
            return root.getRight();
        BinNode<T> parent = null;
        BinNode<T> current = root;
        while (current.hasLeft()) {
            parent = current;
            current = current.getLeft();
        }
        parent.setLeft(current.getRight());
        return root;
    }

    // 12. Delete last (delete rightmost)
    public static <T> BinNode<T> deleteLast(BinNode<T> root) {
        if (root == null)
            return null;
        if (!root.hasRight())
            return root.getLeft();
        BinNode<T> parent = null;
        BinNode<T> current = root;
        while (current.hasRight()) {
            parent = current;
            current = current.getRight();
        }
        parent.setRight(current.getLeft());
        return root;
    }

    // 13. Delete at position (by in-order index)
    public static <T> BinNode<T> deleteAtPosition(BinNode<T> root, int index) {
        List<T> list = new ArrayList<>();
        inOrderToList(root, list);
        if (index >= 0 && index < list.size()) {
            list.remove(index);
        }
        return buildBalancedTree(list, 0, list.size() - 1);
    }

    // 14. Find middle node (by in-order index)
    public static <T> BinNode<T> findMiddleNode(BinNode<T> root) {
        List<BinNode<T>> nodes = new ArrayList<>();
        inOrderNodes(root, nodes);
        if (nodes.isEmpty())
            return null;
        return nodes.get(nodes.size() / 2);
    }

    // 15. Reverse list (swap left and right recursively)
    public static <T> BinNode<T> reverseList(BinNode<T> node) {
        if (node == null)
            return null;
        BinNode<T> left = reverseList(node.getLeft());
        BinNode<T> right = reverseList(node.getRight());
        node.setLeft(right);
        node.setRight(left);
        return node;
    }

    // 16. Iterate reverse (reverse in-order: right → root → left)
    public static <T> void iterateReverse(BinNode<T> node) {
        if (node == null)
            return;
        iterateReverse(node.getRight());
        System.out.println(node.getValue());
        iterateReverse(node.getLeft());
    }

    // 17. Count nodes
    public static <T> int countNodes(BinNode<T> node) {
        if (node == null)
            return 0;
        return 1 + countNodes(node.getLeft()) + countNodes(node.getRight());
    }

    // 18. Contains value
    public static <T> boolean containsValue(BinNode<T> node, T value) {
        if (node == null)
            return false;
        if (node.getValue().equals(value))
            return true;
        return containsValue(node.getLeft(), value) || containsValue(node.getRight(), value);
    }

    // 19. Copy tree
    public static <T> BinNode<T> copyList(BinNode<T> node) {
        if (node == null)
            return null;
        BinNode<T> newNode = new BinNode<>(node.getValue());
        newNode.setLeft(copyList(node.getLeft()));
        newNode.setRight(copyList(node.getRight()));
        return newNode;
    }

    // 20. Merge two trees (simple: left tree inserted at rightmost of first)
    public static <T> BinNode<T> mergeTwoLists(BinNode<T> root1, BinNode<T> root2) {
        if (root1 == null)
            return root2;
        BinNode<T> current = root1;
        while (current.hasRight()) {
            current = current.getRight();
        }
        current.setRight(root2);
        return root1;
    }
}
