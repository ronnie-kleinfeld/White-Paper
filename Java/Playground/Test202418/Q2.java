package Test202418;

import java.util.*;

public class Q2 {
    public static void main(String[] args) {

    }

    public static boolean check(int productsCount) {
        Scanner scanner = new Scanner(System.in);
        int sum = 0;

        for (int i = 0; i < productsCount; i++) {
            sum += scanner.nextInt();
        }

        return sum > 150;
    }

    public static void checkAll() {
        Scanner scanner = new Scanner(System.in);
        int counter = 0;

        for (int i = 0; i < 850; i++) {
            if (check(scanner.nextInt())) {
                counter++;
            }
        }

        System.out.println(counter);
    }
}