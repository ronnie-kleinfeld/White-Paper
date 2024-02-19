public class Q6 {
    // Study
    // dyutS
    // 34210
    public static void main(String[] args) {
        System.out.println(Q6("rdoWl", new int[] { 2, 4, 1, 0, 3 }));
        System.out.println(Q6("dyutS", new int[] { 3, 4, 2, 1, 0 }));
    }

    public static String Q6(String str, int[] arr) {
        char[] arrc = new char[arr.length];

        for (int i = 0; i < arr.length; i++) {
            char letter = str.charAt(i); // d
            int location = arr[i]; // 3

            arrc[location] = letter;
        }

        String result = "";
        for (int i = 0; i < arrc.length; i++) {
            result += arrc[i];
        }

        return result;
    }
}