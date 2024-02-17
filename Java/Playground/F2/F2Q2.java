package F2;

public class F2Q2 {
    public static void main(String[] args) {
        int[][] arr = new int[5][7];
        arr[0] = new int[] { 39, 72, 3, 8, 0, 2, 54 };
        arr[1] = new int[] { 18, 16, 13, 47, 41, 87, 65 };
        arr[2] = new int[] { 34, 78, 37, 99, 97, 46, 56 };
        arr[3] = new int[] { 51, 50, 12, 31, 58, 63, 18 };
        arr[4] = new int[] { 23, 4, 11, 26, 83, 25, 67 };

        printInRange(arr, 12, 22); // 87, 65, 34, 78, 37, 99, 97, 46, 56, 51, 50
        printInRange(arr, 9, 10); // 13, 47
        printInRange(arr, 9, 15); // 13, 47, 41, 87, 65, 34, 78
    }

    public static void printInRange(int[][] m, int counter1, int counter2) {
        int counter = 0;
        String result = "";

        for (int i = 0; i < m.length; i++) {
            for (int j = 0; j < m[i].length; j++) {
                if (counter >= counter1 && counter <= counter2) {
                    if (result == "")
                        result += m[i][j];
                    else
                        result += ", " + m[i][j];
                }
                counter++;
            }
        }

        System.out.println(result);
    }
    // 87
    // 87, 65
    //
}