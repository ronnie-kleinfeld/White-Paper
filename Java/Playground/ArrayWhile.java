public class ArrayWhile {
    public static void main(String[] args) {
        ForOnArrayBeginToEnd(new int[] { 1, 2, 3, 4, 5 });
        ForOnArrayEndToBegin(new int[] { 1, 2, 3, 4, 5 });

        ForOnArrayEvenOdd(new int[] { 1, 2, 3, 4 });
        ForOnArrayEvenOdd(new int[] { 1, 2, 3, 4, 5 });

        WhileOnArrayHalfAndHalf(new int[] { 1, 2, 3, 4 });
        WhileOnArrayHalfAndHalf(new int[] { 1, 2, 3, 4, 5 });
    }

    public static void ForOnArrayBeginToEnd(int[] arr) {
        for (int index = 0; index < arr.length; index++) {
            int item = arr[index];
            System.out.println(item);
        }
    }

    public static void ForOnArrayEndToBegin(int[] arr) {
        for (int index = arr.length - 1; index >= 0; index--) {
            int item = arr[index];
            System.out.println(item);
        }
    }

    public static void ForOnArrayEvenOdd(int[] arr) {
        for (int index = 0; index < arr.length; index++) {
            int item = arr[index];
            if (item % 2 == 0) {
                System.out.println(item + " זוגי");
            } else {
                System.out.println(item + " אי זוגי");
            }
        }
    }

    public static void WhileOnArrayHalfAndHalf(int[] arr) {
        int length = arr.length;
        int index = 0;

        while (index < length) {
            int item = arr[index];

            if (index < length / 2) {
                System.out.println(item + " top");
            } else if (length % 2 == 1 && index == length / 2) {
                System.out.println(item + " middle");
            } else if (index >= length / 2) {
                System.out.println(item + " bottom");
            }

            index++;
        }
    }
}