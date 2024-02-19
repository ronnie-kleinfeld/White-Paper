public class Array {
    public static void main(String[] args) {

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
}