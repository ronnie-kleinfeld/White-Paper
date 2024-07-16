public class Bagrut11 {
    public static void main(String[] args) {
        int[] arr = { 30, 141, 324, 623, 8004, 458, 6 };

        int count = 0;
        for (int i = 0; i < arr.length; i++) {
            int num = arr[i] / 10;
            int digit = num % 10;
            if (digit == i) {
                count++;
            }
        }

        System.out.println(count);
    }

}