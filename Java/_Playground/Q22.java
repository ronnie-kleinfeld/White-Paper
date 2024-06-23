public class Q22 {
    public static void main(String[] args) {
        System.out.println(Q2(new int[] { 12, 34, 56, 78, 90 }));
        System.out.println(Q2(new int[] { 12, 34, 56, 78, 99, 78 }));
    }

    public static boolean Q2(int[] arr) {
        boolean[] digits = new boolean[10];

        for (int i = 0; i < arr.length; i++) {
            int number = arr[i];
            int digit1 = number / 10;
            int digit2 = number - digit1 * 10;

            System.out.println(number);
            System.out.println(digit1);
            System.out.println(digit2);

            digits[digit1] = true;
            digits[digit2] = true;
        }

        for (int i = 0; i < digits.length; i++) {
            if (digits[i] == false) {
                return false;
            }
        }
        return true;
    }
}