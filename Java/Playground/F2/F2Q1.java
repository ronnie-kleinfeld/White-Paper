package F2;

public class F2Q1 {
    public static void main(String[] args) {
        int[][] arr = new int[5][7];
        arr[0] = new int[] { 39, 72, 3, 8, 0, 2, 54 };
        arr[1] = new int[] { 18, 16, 13, 47, 41, 87, 65 };
        arr[2] = new int[] { 34, 78, 37, 99, 97, 46, 56 };
        arr[3] = new int[] { 51, 50, 12, 31, 58, 63, 18 };
        arr[4] = new int[] { 23, 4, 11, 26, 83, 25, 67 };

        System.out.println(Q11a(arr, 13));
        System.out.println(Q11b(arr, 13));

        System.out.println(Q11a(arr, 83));
        System.out.println(Q11b(arr, 83));

        System.out.println(Q11a(arr, 100));
        System.out.println(Q11b(arr, 100));
    }

    public static int Q11a(int[][] m, int num) {
        int counter = 0;

        for (int i = 0; i < m.length; i++) {
            for (int j = 0; j < m[i].length; j++) {
                if (m[i][j] == num) {
                    return counter;
                }
                counter++;
            }
        }

        return -1;
    }

    public static int Q11b(int[][] m, int num) {
        for (int i = 0; i < m.length; i++) {
            for (int j = 0; j < m[i].length; j++) {
                if (m[i][j] == num) {
                    return (i * m[i].length + j);
                }
            }
        }

        return -1;
    }
}