import java.util.Arrays;

public class Track1 {
    public static void main(String[] args) {
        // Example 1
        int[] numbers1 = { 3, 8, 1, 5, 2 };
        int m1 = 7;
        int[] result1 = modifiedQ1(numbers1, m1);
        System.out.println("Example 1 Output: " + Arrays.toString(result1));

        // Example 2
        int[] values1 = { 2, 4, 6, 8, 10 };
        int m2 = 15;
        int[] result2 = modifiedQ2(values1, m2);
        System.out.println("Example 2 Output: " + Arrays.toString(result2));

        // Example 3
        int[] data1 = { 1, -3, 5, 2, 0 };
        int m3 = 4;
        int[] result3 = modifiedQ3(data1, m3);
        System.out.println("Example 3 Output: " + Arrays.toString(result3));
    }

    // Modified algorithms go here (modifiedQ1, modifiedQ2, modifiedQ3)

    public static int[] modifiedQ1(int[] arr, int m) {
        int[] result = new int[arr.length];

        for (int i = 0; i < arr.length; i++) {
            result[i] = Math.max(arr[i], m);
        }

        return result;
    }

    public static int[] modifiedQ2(int[] arr, int m) {
        int[] result = new int[arr.length];
        result[0] = arr[0];

        for (int i = 1; i < arr.length; i++) {
            result[i] = Math.max(result[i - 1] + arr[i], m);
        }

        return result;
    }

    public static int[] modifiedQ3(int[] arr, int m) {
        int[] result = new int[arr.length];

        for (int i = 0; i < arr.length; i++) {
            result[i] = Math.min(arr[i], m);
        }

        return result;
    }
}