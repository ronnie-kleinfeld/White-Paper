import java.util.Arrays;

public class _ArrayRemove {
    public static void main(String[] args) {
        RemoveByIndex(new int[] { 0 }, 0);
        RemoveByIndex(new int[] { 0, 1 }, 0);
        RemoveByIndex(new int[] { 0, 1 }, 1);
        RemoveByIndex(new int[] { 0, 1, 2 }, 0);
        RemoveByIndex(new int[] { 0, 1, 2 }, 1);
        RemoveByIndex(new int[] { 0, 1, 2 }, 2);
    }

    public static int[] RemoveByIndex(int[] arr, int removeIndex) {
        int[] newArr = new int[arr.length - 1];
        int newIndex = 0;

        for (int i = 0; i < arr.length; i++) {
            if (i != removeIndex) {
                newArr[newIndex++] = arr[i];
            }
        }

        return newArr;
    }

    public static int findHighValue(int[] arr) {
        int highValue = arr[0];
        for (int index = 0; index < arr.length; index++) {
            int item = arr[index];
            if (item > highValue) {
                highValue = item;
            }
        }
        return highValue;
    }

    public static int findBoxWithHighestLength(Box[] arr) {
        Box box = arr[0];
        for (int index = 0; index < arr.length; index++) {
            Box item = arr[index];
            if (item.length > box.length) {
                box = item;
            }
        }
        return box.length;
    }

    public static int findHighValueIndex(int[] arr) {
        int result = -1;
        int highValue = arr[0];
        for (int index = 0; index < arr.length; index++) {
            int item = arr[index];
            if (item > highValue) {
                highValue = item;
                result = index;
            }
        }
        return result;
    }
}