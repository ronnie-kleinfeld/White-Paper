public class QJ3 {
    public static void main(String[] args) {
        int[] arr = new int[] { 2, 5, 4, 15, 3, 40, 9, 8 };
        System.out.println(Check(arr, 6));
        System.out.println(What(arr));
    }

    public static boolean Check(int[] arr, int x) {
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] != 1 && arr[i] != x && x % arr[i] == 0)
                return true;
        }
        return false;
    }

    public static int What(int[] arr) {
        int sum = 0;
        for (int i = 0; i < arr.length; i++) {
            if (Check(arr, arr[i])) {
                sum += arr[i];
            }
            System.out.println(arr[i] + " " + sum);
        }
        return sum;
    }
}
