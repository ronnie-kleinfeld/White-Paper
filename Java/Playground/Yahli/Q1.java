import java.util.Arrays;

public class Q1 {
    public static void main(String[] args) {
        int[] arr = new int[] { 3, 4, 9, 6, 8, 4, 2 };
        System.out.println(Arrays.toString(arr));

        int sum = arr[0];
        for (int i = 1; i < arr.length; i++) {
            arr[i] = arr[i] - sum;
            sum += arr[i];
        }

        System.out.println(Arrays.toString(arr));
    }
}