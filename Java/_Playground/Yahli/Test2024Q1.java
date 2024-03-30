import java.util.Arrays;

public class Test2024Q1 {
    public static void main(String[] args) {
        int[] arr = new int[] { 2, 4, 4, 2, 1, 9 };
        System.out.println(hasOccurences(arr, 2, 2));
        System.out.println(hasOccurences(arr, 2, 3));
        System.out.println(hasOccurences(arr, 1, 1));
        System.out.println(hasOccurences(arr, 1, 2));
        System.out.println(hasOccurences(arr, 6, 2));

        System.out.println(Arrays.toString(removeBalancedNums(arr)));
    }

    public static boolean hasOccurences(int[] arr, int num, int count) {
        int counter = 0;
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == num) {
                counter++;
            }
        }

        return counter == count;
    }

    public static int[] removeBalancedNums(int[] arr) {
        int[] temp = arr.clone();
        System.out.println(temp.length);

        int location = 0;
        for (int i = 0; i < arr.length; i++) {
            if (!hasOccurences(arr, arr[i], arr[i])) {
                temp[location] = arr[i];
                location++;
            }
        }

        int[] result = new int[location];
        for (int i = 0; i < location; i++) {
            result[i] = temp[i];
        }

        return result;
    }
}