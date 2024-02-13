import java.util.Arrays;

public class Q2 {
    public static void main(String[] args) {
        Q2_1();
        Q2_2();
    }

    public static void Q2_1() {
        int[] a = { 2, 3, 2 };
        System.out.println(Arrays.toString(a));
        int[] b = q(a, 6);
        System.out.println(Arrays.toString(b));
    }

    public static void Q2_2() {
        int[] a = { 2, 1, 3, 1 };
        System.out.println(Arrays.toString(a));
        int[] b = q(a, 8);
        System.out.println(Arrays.toString(b));
        System.out.println(a[3]);
        System.out.println(b[3]);
    }

    public static int[] q(int[] arr, int m) {
        int[] ret = new int[arr.length];
        ret[0] = arr[0];
        for (int i = 1; i < arr.length; i++) {
            ret[i] = Math.min(ret[i - 1] + arr[i], m);
        }
        return ret;
    }
}