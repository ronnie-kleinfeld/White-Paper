package Test202418;

import java.util.Arrays;

public class Q1 {
    public static void main(String[] args) {
        int[] a = { 2, 8, 8, 8, 12, 24, 7, 7, 6 };
        int[] b = { 0, 0, 0, 0, 0, 0, 0, 0 };

        System.out.println(Arrays.toString(a));
        System.out.println(Arrays.toString(b));

        int count = 0;
        for (int i = 0; i < (a.length - 1); i++) {
            if (a[i] == a[i + 1]) {
                b[count] = a[i];
                count++;
            }
        }

        System.out.println(Arrays.toString(a));
        System.out.println(Arrays.toString(b));
    }
}