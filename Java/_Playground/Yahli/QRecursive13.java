public class QRecursive13 {
    public static void main(String[] args) {
        System.out.println(digitCount(0) == 1);
        System.out.println(digitCount(1) == 1);
        System.out.println(digitCount(9) == 1);
        System.out.println(digitCount(10) == 2);
        System.out.println(digitCount(11) == 2);
        System.out.println(digitCount(20) == 2);
        System.out.println(digitCount(99) == 2);
        System.out.println(digitCount(100) == 3);
        System.out.println(digitCount(999) == 3);
        System.out.println(digitCount(1000) == 4);

        System.out.println("ronnie");
        System.out.println(q13(4, 5) == true);
        System.out.println(q13(4, 9) == true);
        System.out.println(q13(43, 94) == true);
        System.out.println(q13(4, 92) == false);
        System.out.println(q13(43, 9) == false);

        System.out.println("yahli");
        System.out.println(q13b(4, 5) == true);
        System.out.println(q13b(4, 9) == true);
        System.out.println(q13b(43, 94) == true);
        System.out.println(q13b(4, 92) == false);
        System.out.println(q13b(43, 9) == false);
    }

    public static boolean q13(int x, int y) {
        return digitCount(x) == digitCount(y);
    }

    public static boolean q13b(int x, int y) {
        if (x == 0 && y == 0) {
            return true;
        } else if (x == 0) {
            return false;
        } else if (y == 0) {
            return false;
        }
        return q13b(x / 10, y / 10);
    }

    public static int digitCount(int x) {
        if (x < 10) {
            return 1;
        }
        return digitCount(x / 10) + 1;
    }
}