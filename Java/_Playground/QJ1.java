import java.util.Scanner;

public class QJ1 {
    public static void main(String[] args) {
        System.out.println(Q1(11));
        System.out.println(Q1(12));
        System.out.println(Q1(13));
        System.out.println(Q1(21));
        System.out.println(Q1(22));
        System.out.println(Q1(23));

        System.out.println(Q2());
    }

    public static boolean Q1(int num) {
        return num >= 12 && num <= 22;
    }

    public static int Q2() {
        int count = 0;

        while (true) {
            Scanner scanner = new Scanner(System.in);
            int age = scanner.nextInt();
            int hours = scanner.nextInt();

            if (age == 999) {
                break;
            } else if (Q1(age) && hours > 3) {
                count++;
            }
        }

        return count;
    }

    public static void Q3() {
        int[] counters = new int[11];

        for (int i = 0; i < 100; i++) {
            Scanner scanner = new Scanner(System.in);
            int age = scanner.nextInt();
            if (Q1(age)) {
                counters[age - 12]++;
            }
        }

        for (int i = 0; i < counters.length; i++) {
            System.out.println(counters[i]);
        }
    }
}
