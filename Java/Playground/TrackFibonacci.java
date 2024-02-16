import java.util.Arrays;

public class TrackFibonacci {
    public static void main(String[] args) {
        // Original Fibonacci sequence
        int[] originalFibonacci = generateFibonacci(10);
        System.out.println("Original Fibonacci: " + Arrays.toString(originalFibonacci));
        System.out.println("Original Fibonacci: " + arrayToString(originalFibonacci));
    }

    // Original Fibonacci generation logic
    public static int[] generateFibonacci(int n) {
        int[] fibonacci = new int[n];
        fibonacci[0] = 0;
        fibonacci[1] = 1;

        for (int i = 2; i < n; i++) {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        return fibonacci;
    }

    // Helper method to convert array to string for printing
    public static String arrayToString(int[] arr) {
        String result = "";

        for (int i = 0; i < arr.length; i++) {
            result += arr[i];
            if (i < arr.length - 1) {
                result += ", ";
            }
        }
        return result;
    }
}