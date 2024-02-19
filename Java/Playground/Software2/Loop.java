public class Loop {
    public static void forForward(int[] arr) {
        for (int i = 0; i < arr.length; i++) {
            int item = arr[i];
            // item in index
        }
    }

    public static void forReverse(int[] arr) {
        for (int i = arr.length - 1; i >= 0; i--) {
            int item = arr[i];
            // item in index
        }
    }

    public static void forForwardStep2(int[] arr) {
        for (int i = 0; i < arr.length; i++) {
            int item = arr[i];
            if (i % 2 == 0) {
                // זוגי - item in index
            } else {
                // אי זוגי - item in index
            }
        }
    }

    public static void forForwardStep3(int[] arr) {
        for (int i = 0; i < arr.length; i++) {
            int item = arr[i];
            if (i % 3 == 1) {
                // item in index 1/3
            } else if (i % 3 == 2) {
                // item in index 2/3
            } else {
                // item in index 3/3
            }
        }
    }

    public static void forHalfAndHalf(int[] arr) {
        int length = arr.length;
        int index = 0;
        while (index < length) {
            int item = arr[index];
            if (index < length / 2) {
                // items on left in index
            } else if (length % 2 == 1 && index == length / 2) {
                // middle items in index
            } else if (index >= length / 2) {
                // items on right in index
            }
            index++;
        }
    }
}