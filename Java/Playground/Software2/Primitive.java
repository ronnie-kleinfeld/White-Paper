public class Primitive {
    public static void initPrimitive() {
        int i = 0; // 0 מספר שלם
        double d = 0.0; // 0.0 מספר ממשי
        String str = ""; // מחרוזת
        char c = ' '; // אות
        Boolean b = true; // false בוליאני
    }

    public static void initArrayOfPrimitives() {
        int[] arri1 = new int[2]; // [0, 0]
        int[] arri2 = { 1, 2 }; // [1, 2]

        double[] arrd1 = new double[2]; // [0.0, 0.0]
        double[] arrd2 = { 1.2, 2.3 }; // [1.2, 2.3]

        String[] arrstr1 = new String[2]; // [null, null]
        String[] arrstr2 = { "ab", "cd" }; // ["ab", "cd"]

        char[] arrc1 = new char[2]; // [, ]
        char[] arrc2 = { 'a', 'b' }; // ['a', 'b']

        Boolean[] arrb1 = new Boolean[2]; // [null, null]
        Boolean[] arrb2 = { true, false }; // [true, false]
    }

    public static void init2DArrayOfPrimitives() {
        int[][] matrix1 = new int[3][4];
        int[][] matrix2 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 3, 9, 0, 5 } };
    }
}