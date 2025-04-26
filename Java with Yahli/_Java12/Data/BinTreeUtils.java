package Data;

import java.util.LinkedList;
import java.util.Queue;

public class BinTreeUtils {

    public static <T> void iterateBinTreeNodes(BinTreeNode<T> root) {
        if (root == null)
            return;
        System.out.println(root.GetInfo());
        iterateBinTreeNodes(root.GetLeft());
        iterateBinTreeNodes(root.GetRight());
    }

    public static <T> T getFirstBinTreeItem(BinTreeNode<T> root) {
        return (root != null) ? root.GetInfo() : null;
    }

    public static <T> T getLastBinTreeItem(BinTreeNode<T> root) {
        if (root == null)
            return null;
        Queue<BinTreeNode<T>> queue = new LinkedList<>();
        queue.add(root);
        BinTreeNode<T> last = root;
        while (!queue.isEmpty()) {
            last = queue.poll();
            if (last.GetLeft() != null)
                queue.add(last.GetLeft());
            if (last.GetRight() != null)
                queue.add(last.GetRight());
        }
        return last.GetInfo();
    }

    public static <T> BinTreeNode<T> rotateBinTreeLeft(BinTreeNode<T> root) {
        if (root == null || root.GetRight() == null)
            return root;
        BinTreeNode<T> newRoot = root.GetRight();
        root.SetRight(newRoot.GetLeft());
        newRoot.SetLeft(root);
        return newRoot;
    }

    public static <T> BinTreeNode<T> rotateBinTreeRight(BinTreeNode<T> root) {
        if (root == null || root.GetLeft() == null)
            return root;
        BinTreeNode<T> newRoot = root.GetLeft();
        root.SetLeft(newRoot.GetRight());
        newRoot.SetRight(root);
        return newRoot;
    }

    public static <T> int getBinTreeNodePosition(BinTreeNode<T> root, T value) {
        return getBinTreeNodePositionHelper(root, value, 0);
    }

    private static <T> int getBinTreeNodePositionHelper(BinTreeNode<T> node, T value, int index) {
        if (node == null)
            return -1;
        if (node.GetInfo().equals(value))
            return index;
        int left = getBinTreeNodePositionHelper(node.GetLeft(), value, 2 * index + 1);
        if (left != -1)
            return left;
        return getBinTreeNodePositionHelper(node.GetRight(), value, 2 * index + 2);
    }

    public static <T> BinTreeNode<T> getBinTreeNodeByIndex(BinTreeNode<T> root, int index) {
        if (root == null)
            return null;
        Queue<BinTreeNode<T>> queue = new LinkedList<>();
        queue.add(root);
        int currentIndex = 0;
        while (!queue.isEmpty()) {
            BinTreeNode<T> node = queue.poll();
            if (currentIndex == index)
                return node;
            if (node.GetLeft() != null)
                queue.add(node.GetLeft());
            if (node.GetRight() != null)
                queue.add(node.GetRight());
            currentIndex++;
        }
        return null;
    }

    public static <T> BinTreeNode<T> insertAtBinTreeHead(BinTreeNode<T> root, T value) {
        return new BinTreeNode<>(value);
    }

    public static <T> void insertAtBinTreeTail(BinTreeNode<T> root, T value) {
        if (root == null)
            return;
        Queue<BinTreeNode<T>> queue = new LinkedList<>();
        queue.add(root);
        while (!queue.isEmpty()) {
            BinTreeNode<T> node = queue.poll();
            if (node.GetLeft() == null) {
                node.SetLeft(new BinTreeNode<>(value));
                return;
            } else {
                queue.add(node.GetLeft());
            }
            if (node.GetRight() == null) {
                node.SetRight(new BinTreeNode<>(value));
                return;
            } else {
                queue.add(node.GetRight());
            }
        }
    }

    public static <T> void insertAtBinTreePosition(BinTreeNode<T> root, int index, T value) {
        BinTreeNode<T> parent = getBinTreeNodeByIndex(root, (index - 1) / 2);
        if (parent == null)
            return;
        if (index % 2 == 1) {
            parent.SetLeft(new BinTreeNode<>(value));
        } else {
            parent.SetRight(new BinTreeNode<>(value));
        }
    }

    public static <T> BinTreeNode<T> deleteFirstBinTreeNode(BinTreeNode<T> root) {
        return null; // No natural meaning for binary tree
    }

    public static <T> BinTreeNode<T> deleteLastBinTreeNode(BinTreeNode<T> root) {
        return null; // No natural meaning for binary tree
    }

    public static <T> void deleteBinTreeNodeAtPosition(BinTreeNode<T> root, int index) {
        // Not implemented (complex for binary trees without parent links)
    }

    public static <T> BinTreeNode<T> findMiddleBinTreeNode(BinTreeNode<T> root) {
        if (root == null)
            return null;
        int count = countBinTreeNodes(root);
        return getBinTreeNodeByIndex(root, count / 2);
    }

    public static <T> BinTreeNode<T> reverseBinTree(BinTreeNode<T> root) {
        if (root == null)
            return null;
        BinTreeNode<T> temp = root.GetLeft();
        root.SetLeft(reverseBinTree(root.GetRight()));
        root.SetRight(reverseBinTree(temp));
        return root;
    }

    public static <T> void iterateBinTreeReverse(BinTreeNode<T> root) {
        if (root == null)
            return;
        iterateBinTreeReverse(root.GetRight());
        System.out.println(root.GetInfo());
        iterateBinTreeReverse(root.GetLeft());
    }

    public static <T> int countBinTreeNodes(BinTreeNode<T> root) {
        if (root == null)
            return 0;
        return 1 + countBinTreeNodes(root.GetLeft()) + countBinTreeNodes(root.GetRight());
    }

    public static <T> boolean containsBinTreeValue(BinTreeNode<T> root, T value) {
        if (root == null)
            return false;
        if (root.GetInfo().equals(value))
            return true;
        return containsBinTreeValue(root.GetLeft(), value) || containsBinTreeValue(root.GetRight(), value);
    }

    public static <T> BinTreeNode<T> copyBinTree(BinTreeNode<T> root) {
        if (root == null)
            return null;
        return new BinTreeNode<>(copyBinTree(root.GetLeft()), root.GetInfo(), copyBinTree(root.GetRight()));
    }

    public static <T> BinTreeNode<T> mergeTwoBinTrees(BinTreeNode<T> root1, BinTreeNode<T> root2) {
        if (root1 == null)
            return copyBinTree(root2);
        if (root2 == null)
            return copyBinTree(root1);
        BinTreeNode<T> newRoot = new BinTreeNode<>(root1.GetInfo());
        newRoot.SetLeft(mergeTwoBinTrees(root1.GetLeft(), root2.GetLeft()));
        newRoot.SetRight(mergeTwoBinTrees(root1.GetRight(), root2.GetRight()));
        return newRoot;
    }
}
