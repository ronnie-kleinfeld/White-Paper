import java.util.Arrays;

public class Test2024Q3 {
    public static void main(String[] args) {
        int[][] arr = new int[][] {
                { 1, 3, 5, 7, 9 },
                { 8, 12, 16, 20, 24 },
                { 2, 9, 16, 23, 30 },
                { 12, 22, 32, 42, 52 } };
        System.out.println(hasDiffInRow(arr, 0, 2));
        System.out.println(hasDiffInRow(arr, 0, 3));

        System.out.println(isIncreasingDiff(arr));
    }

    public static boolean hasDiffInRow(int[][] arr, int row, int diff) {
        for (int i = 0; i < arr[row].length - 1; i++) {
            if (arr[row][i + 1] - arr[row][i] != diff) {
                return false;
            }
        }

        return true;
    }

    public static boolean isIncreasingDiff(int[][] arr) {
        int lastDiff = -1;

        for (int i = 0; i < arr.length; i++) {
            int currentDiff = arr[i][1] - arr[i][0];

            if (!hasDiffInRow(arr, i, currentDiff)) {
                return false;
            }

            if (currentDiff > lastDiff) {
                lastDiff = currentDiff;
            } else {
                return false;
            }
        }

        return true;
    }
}