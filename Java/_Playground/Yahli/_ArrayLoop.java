public class _ArrayLoop {
    public static void main(String[] args) {
        ForOnArrayForward(new int[] { 1, 2, 3, 4, 5 });
        System.out.println();
        ForOnArrayReverse(new int[] { 1, 2, 3, 4, 5 });
        System.out.println();

        ForOnArrayEvenOddForward(new int[] { 1, 2, 3, 4 });
        System.out.println();
        ForOnArrayEvenOddForward(new int[] { 1, 2, 3, 4, 5 });
        System.out.println();

        ForOnArrayEvenOddReverse(new int[] { 1, 2, 3, 4 });
        System.out.println();
        ForOnArrayEvenOddReverse(new int[] { 1, 2, 3, 4, 5 });
        System.out.println();

        WhileOnArrayHalfAndHalf(new int[] { 1, 2, 3, 4 });
        System.out.println();
        WhileOnArrayHalfAndHalf(new int[] { 1, 2, 3, 4, 5 });
        System.out.println();
    }

    public static void ForOnArrayForward(int[] arr) {
        for (int index = 0; index < arr.length; index++) {
            int item = arr[index];
            System.out.print(item + "-");
        }
    }

    public static void ForOnArrayReverse(int[] arr) {
        for (int index = arr.length - 1; index >= 0; index--) {
            int item = arr[index];
            System.out.print(item + "-");
        }
    }

    public static void ForOnArrayEvenOddForward(int[] arr) {
        for (int index = 0; index < arr.length; index++) {
            int item = arr[index];
            if (item % 2 == 0) {
                System.out.print(item + "זוגי -");
            } else {
                System.out.print(item + "אי זוגי -");
            }
        }
    }

    public static void ForOnArrayEvenOddReverse(int[] arr) {
        for (int index = arr.length - 1; index >= 0; index--) {
            int item = arr[index];
            if (item % 2 == 0) {
                System.out.print(item + "זוגי -");
            } else {
                System.out.print(item + "אי זוגי -");
            }
        }
    }

    public static void WhileOnArrayHalfAndHalf(int[] arr) {
        int length = arr.length;
        int index = 0;

        while (index < length) {
            int item = arr[index];

            if (index < length / 2) {
                System.out.print(item + " top -");
            } else if (length % 2 == 1 && index == length / 2) {
                System.out.print(item + " middle - ");
            } else if (index >= length / 2) {
                System.out.print(item + " bottom - ");
            }

            index++;
        }
    }
}