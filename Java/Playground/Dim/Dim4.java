package Dim;

/**
 * Main class of the Java program. 
 * 
 */
import java.util.Arrays;

// output
// 1 הפעולה מקבלת מספר שלם הפעולה מחזירה מערך באורך זה שבו יש את הספרות 0-9 בצורה מחזורית
// 2 הפעולה מקבלת מערך מספרים הפעולה מחזירה מערך חדש ובו המספרים השליליים בהתחלה,באותו סדר,אחכ אפסים ואחכ מספרים חיוביים בסדר הפוך
// 3 הפעולה מקבלת מספר הפעולה מחזירה מערך ובו המספרים מ 1 עד המספר שהתקבל כפרמטר וכל מספר נמצא מספר פעמים כערכו
// 4 הפעולה מקבלת שני מערכים הפעולה מחזירה מערך חדש ובו מסודרים האיברים אחד מהמערך הראשון ואחד מהשני אם נשארים איברים באחד המערכים,הם יהיו בסוף
// 5 הפעולה מקבלת איבר ראשון,הפרש סדרה ומספר איברים מבוקש הפעולה תחזיר מערך והו איברי הסידרה החשבונית המבוקשת
// 6 הפעולה מקבלת מערך מספרים הפעולה תחזיר מערך ובו אין איברים כפולים
// 7 הפעולה מקבלת מספר איברים רצוי הפעולה תחזיר מערך באורך זה ובו סדרת טריבונצי
// 8 הפעולה מקבלת שני מערכים הפעולה מחזירה את מערך האיחוד-מספרים שנמצאים לפחות באחד המערכים,ללא כפילויות
// 9 הפעולה מקבלת שני מערכים הפעולה מחזירה את מערך החיתוך-מספרים שנמצאים בשני המערכים ללא כפילו
// 10 הפעולה מקבלת שני מערכים ממויינים הפעולה מחזירה את מערך האיחוד-מספרים שנמצאים לפחות באחד המערכים,ללא כפ יש להתייחס בפיתרון לכך שהמערכים ממויינים
public class Dim4 {

    public static void main(String[] args) {

    }

    /* 1 - repeatingSequence(int n) */
    // returns arr length n, with values 0-9
    // [0,1,2,3,4,5,6,7,8,9,0,1,2,3,4,5,6,7,8,9,0,1,2,3,4........]
    /*
     * 1 - int[] repeatingSequence(int n)
     * repeatingSequence(23)
     * result: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2]
     */
    public static int[] repeatingSequence(int n) {
        return null;
    }

    /* 2 - negPos(int[] arr) */
    // returns new arr where negative numbers at arr start
    // and not negative numbers are at arr end in reverse order
    /*
     * 2 - int[] negPos(int[] arr)
     * negPos([2, 4, -7, 1, -5, 3, 0, -8])
     * result: [-7, -5, -8, 0, 3, 1, 4, 2]
     * negPos([2, 5, 3, 7, 6, 9])
     * result: [9, 6, 7, 3, 5, 2]
     */
    public static int[] negPos(int[] arr) {
        return null;
    }

    /* 3 - repeatNTimes(int n) */
    // returns an array of integers representing the sequence 1, 2, 2, 3, 3, 3, ...,
    // n
    /*
     * 3 - int[] repeatNTimes(int n)
     * repeatNTimes(6)
     * result: [1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6]
     */
    public static int[] repeatNTimes(int n) {
        return null;
    }

    /* 4 - alternatelyConcatenate(int[] arr1, int[] arr2) */
    // returns new arr where its values are alternately arr1 and arr2 value
    // left values will be at end
    /*
     * 4 - alternatelyConcatenate(int[] arr1, int[] arr2)
     * alternatelyConcatenate([1, 2, 3, 4] [5, 6, 7, 8, 9, 10, 11])
     * result: [1, 5, 2, 6, 3, 7, 4, 8, 9, 10, 11]
     * alternatelyConcatenate([5, 6, 7, 8, 9, 10, 11] [1, 2, 3, 4])
     * result: [5, 1, 6, 2, 7, 3, 8, 4, 9, 10, 11]
     */
    public static int[] alternatelyConcatenate(int[] arr1, int[] arr2) {
        return null;
    }

    /* 5 - arithmeticProgression(int a1, int d, int n) */
    // returns an array length n of arithmeticProgression a(n) = a(n-1) + d
    /*
     * 5 - int[] arithmeticProgression(int a1, int d, int n)
     * arithmeticProgression(5,3,12)
     * result: [5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38]
     */
    public static int[] arithmeticProgression(int a1, int d, int n) {
        return null;
    }

    /* 6 - noDuply(int[] arr */
    // returns new arr with no duplications
    /*
     * 6 - int[] noDuply(int[] arr)
     * noDuply([3, 7, 1, 3, 7, 2, 1, 1, 4, 4])
     * result: [3, 7, 1, 2, 4]
     * noDuply([1, 2, 3, 4, 5])
     * result: [1, 2, 3, 4, 5]
     */
    public static int[] noDuply(int[] arr) {
        return null;
    }

    /* 7 - tribonacciArr(int n) */
    // returns an array length n of tribonacci serious
    // a1 = 0, a2 = 0, a3 = 1, a(n) = a(n-3) + a(n-2) + a(n-1)
    /*
     * 7 - int[] tribonacciArr(int n)
     * tribonacciArr(12)
     * result: [0, 0, 1, 1, 2, 4, 7, 13, 24, 44, 81, 149]
     */
    public static int[] tribonacciArr(int n) {
        return null;
    }

    /* 8 - union(int[]a, int[]b) */
    // returns new arr combining all elements of the input arrays, without
    // repetition of elements
    // first - arr1 values
    /*
     * 8 - int[] union(int[]a, int[]b)
     * union([5, 6, 1, 5, 7, 8, 2, 2] [2, 3, 3, 6, 9, 9, 1, 8, 7, 8])
     * result: [5, 6, 1, 7, 8, 2, 3, 9]
     * union([2, 3, 3, 6, 9, 9, 1, 8, 7, 8] [5, 6, 1, 5, 7, 8, 2, 2])
     * result: [2, 3, 6, 9, 1, 8, 7, 5]
     */
    public static int[] union(int[] a, int[] b) {
        int[] union = new int[a.length + b.length];
        return null;
    }

    /* 9 - intersection(int[]a, int[]b) */
    // returns new arr of distinct numbers which are present in both the arrays
    // first - arr1 values
    /*
     * 9 - int[] intersection(int[]a, int[]b)
     * intersection([5, 6, 1, 5, 7, 8, 2, 2] [2, 3, 3, 6, 9, 9, 1, 8, 7, 8])
     * result: [6, 1, 7, 8, 2]
     * intersection([2, 3, 3, 6, 9, 9, 1, 8, 7, 8] [5, 6, 1, 5, 7, 8, 2, 2])
     * result: [2, 6, 1, 8, 7]
     */
    public static int[] intersection(int[] a, int[] b) {
        return null;
    }

    /* 10 - unionSorted(int[]a, int[]b) */
    // returns new sorted arr combining all elements of the sorted input arrays,
    // without repetition of elements
    /*
     * 10 - int[] unionSorted(int[]a, int[]b)
     * unionSorted([1, 2, 2, 3, 5, 7, 9, 10, 10] [2, 3, 3, 4, 5, 5, 6, 6, 8, 11,
     * 12])
     * result: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12]
     */
    public static int[] unionSorted(int[] a, int[] b) {
        return null;
    }

}
