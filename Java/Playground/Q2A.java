public class Q2A {
    public static void main(String[] args) {
        int l = 15;
        System.out.println(14 / 2);
        System.out.println(15 / 2);
        Question2A(5, new Box());
        Question2A(4, new Box());

        LoopOnArrayHalfAndHalf(new int[] { 1, 2, 3, 4 });
        LoopOnArrayHalfAndHalf(new int[] { 1, 2, 3, 4, 5 });

        WhileOnArrayHalfAndHalf(new int[] { 1, 2, 3, 4 });
        WhileOnArrayHalfAndHalf(new int[] { 1, 2, 3, 4, 5 });

        WhileOnArrayBeginToEnd(new int[] { 1, 2, 3, 4, 5 });
        WhileOnArrayEndToBegin(new int[] { 1, 2, 3, 4, 5 });

        WhileOnArrayEven(new int[] { 1, 2, 3, 4 });
        WhileOnArrayEven(new int[] { 1, 2, 3, 4, 5 });

        WhileOnArrayOdd(new int[] { 1, 2, 3, 4 });
        WhileOnArrayOdd(new int[] { 1, 2, 3, 4, 5 });
    }

    public static Box[] Question2A(int length, Box box) {
        return new Box[length];
    }

    public static void WhileOnArrayBeginToEnd(int[] arr) {
        int length = arr.length;
        int index = 0;

        while (index < length) {
            int item = arr[index];
            System.out.println(item);
            index++;
        }
    }

    public static void WhileOnArrayEndToBegin(int[] arr) {
        int length = arr.length;
        int index = length - 1;

        while (index >= 0) {
            int item = arr[index];
            System.out.println(item);
            index--;
        }
    }

    public static void WhileOnArrayEven(int[] arr) {
        int length = arr.length;
        int index = 1;

        while (index < length) {
            int item = arr[index];
            System.out.println(item);
            index += 2;
        }
    }

    public static void WhileOnArrayOdd(int[] arr) {
        int length = arr.length;
        int index = 0;

        while (index < length) {
            int item = arr[index];
            System.out.println(item);
            index += 2;
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

    public static void LoopOnArrayHalfAndHalf(int[] arr) {
        int length = arr.length;

        for (int i = 0; i < length / 2; i++) {
            int item = arr[i];
            System.out.println(item + " top");
        }

        if (length % 2 == 0) {
            for (int i = length / 2; i < length; i++) {
                int item = arr[i];
                System.out.println(item + " bottom");
            }
        } else {
            int item = arr[length / 2];
            System.out.println(item + " middle");

            for (int i = length / 2 + 1; i < length; i++) {
                item = arr[i];
                System.out.println(item + " bottom");
            }
        }
    }

    public static class Box {
        public Box() {
        }
    }
}