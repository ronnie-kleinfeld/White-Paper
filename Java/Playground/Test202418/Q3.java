package Test202418;

import java.util.Scanner;

public class Q3 {
    public static void main(String[] args) {

    }

    public static int[] checkAge(int age) {
        int[] result = new int[3];

        if (age >= 12) {
            result[0] = 1;
        }

        if (age >= 16) {
            result[1] = 1;
        }

        if (age >= 18) {
            result[2] = 1;
        }

        return result;
    }

    public static void count() {
        Scanner scanner = new Scanner(System.in);

        int count0 = 0;
        int count1 = 0;
        int count2 = 0;

        while (true) {
            int age = scanner.nextInt();
            if (age < 12)
                break;

            if (age >= 12) {
                count0++;
            }

            if (age >= 16) {
                count1++;
            }

            if (age >= 18) {
                count2++;
            }
        }

        System.out.println(count0 + "," + count1 + "," + count2);
    }
}