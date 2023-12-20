package Dim;

/**
 * Main class of the Java program. 
 * 
 */
import java.util.Arrays;

public class Dim2 {

    // 1 האיבר המקסימלי
    // 2 האיבר השני בגודלו
    // 3 מספר מופעים של האיבר במערך
    // 4 האיבר השכיח ביותר במערך - זה שמופיע הכי הרבה פעמים
    // 5 האם כל אותיות הא"ב נמצאות במערך?
    // 6 האם המערך הוא פלינדרום? משני הכיוונים אותו דבר
    // 7 האם המערך מחולק לשני חלקים זהים?
    // 8 מה מספר החלקים הזהים שיש במערך?
    // 9 האם אין במערך כפילויות?
    // 10 האם ספרות המספר נמצאות ברצף במערך -ישר או הפוך?
    public static void main(String[] args) {

    }

    /* 1 - max in arr */
    // 1 - max in arr [1, 4, 2, 1, 3]
    // max in arr : 4
    public static int max(int[] arr) {

        return 0;
    }

    /* 2 - sec max in arr */
    // 2 - sec max in arr [1, 4, 2, 1, 3]
    // sec max in arr : 3
    public static int secMax(int[] arr) {

        return 0;
    }

    /* 3 - how many */
    // 3 - how many [1, 4, 2, 1, 3]
    // countMember 3 : 1
    // countMember 1 : 2
    // countMember 7 : 0
    public static int countMember(int[] arr, int num) {

        return 0;
    }

    /* 4 - mostCommon in arr */
    // 4 - mostCommon in arr [1, 4, 2, 1, 3]
    // most Common : 1
    public static int mostCommon(int[] arr) {

        return 0;
    }

    /* 5 - alpabet_ver1 */
    // 5 - allAlpabetIn [q, w, e, r, t, y, u, i, o, p, l, k, j, h, g, f, d, s, a, z,
    // x, c, v, b, n, m]
    // all Alpabet In? : true
    // 5 - allAlpabetIn [q, q, q, r, t, y, u, i, o, p, l, k, j, h, g, f, d, s, a, z,
    // x, c, v, b, n, m]
    // all Alpabet In? : false

    public static boolean allAlpabetIn(char[] arr) {

        return false;
    }

    /* 6 - palindrome */
    // 6 - palindrome [b, g, h, j, h, g, b]
    // palindrome? : true
    // 6 - palindrome [b, g, h, j, j, g, b]
    // palindrome? : false
    // 6 - palindrome [b, g, h, j, j, h, g, b]
    // palindrome? : true
    // 6 - palindrome [b, g, h, j, h, h, g, b]
    // palindrome? : false
    public static boolean palindrome(char[] arr) {

        return false;
    }

    /* 7 - doubleArr */
    // 7 - doubleArr [1, 4, 2, 1, 3, 1, 4, 2, 1, 3]
    // doubleArr? : true
    // 7 - doubleArr [1, 4, 2, 1, 3, 1, 4, 6, 1, 3]
    // doubleArr? : false
    public static boolean doubleArr(int[] arr) {

        return false;
    }

    /* 8 - doubleXArr */
    // 8 - doubleXArr [1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3]
    // doubleXArr : 5
    // 8 - doubleXArr [1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4,
    // 1, 2, 3, 4, 1, 2, 3, 4]
    // doubleXArr : 7
    // 8 - doubleXArr [1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4,
    // 1, 2, 3, 4, 1, 2]
    // doubleXArr : 1
    public static int doubleXArr(int[] arr) {

        return 0;
    }

    public static boolean doubleXArr(int[] arr, int k) {

        return false;
    }

    /* 9 - noDuply */
    // 9 - noDuply [2, 4, 3, 5, 6, 7, 1]
    // noDuply? : true
    // 9 - noDuply [1, 2, 3, 4, 3, 5, 6, 7]
    // noDuply? : false
    public static boolean noDuply(int[] arr) {

        return false;
    }

    /* 10 - numberIn */
    // 10 - numberIn [1, 2, 3, 4, 5, 3, 4, 5, 3, 6, 1, 2]
    // numberIn(345345)? : true
    // numberIn(3457)? : false
    // numberIn(63543)? : true
    public static boolean numberIn(int[] arr, int num) {
        return false;
    }

}
