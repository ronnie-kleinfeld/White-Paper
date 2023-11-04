import java.util.Arrays;

public class _Arrays {
    public static void main(String[] args) {
        // array of int
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 2;
        System.out.println(numbers[0]); // 1
        System.out.println(numbers[1]); // 2
        System.out.println(Arrays.toString(numbers)); // [1, 2, 0, 0, 0]

        // array of string
        String[] names = new String[5];
        names[0] = "Yahli";
        System.out.println(Arrays.toString(names)); // [Yahli, null, null, null, null]

        int[] status = { 2, 3, 5, 1, 4 };
        System.out.println(Arrays.toString(status)); // [2, 3, 5, 1, 4]
        System.out.println(status.length); // 5

        Arrays.sort(status);
        System.out.println(Arrays.toString(status)); // [1, 2, 3, 4, 5]

        // swap in array
        String[] kids = { "Yossi", "Danny" };
        System.out.println(Arrays.toString(kids));

    }
}
