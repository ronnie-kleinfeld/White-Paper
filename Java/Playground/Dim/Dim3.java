package Dim;

/**
 * Main class of the Java program. 
 * 
 */
import java.util.Arrays;

// output
// 1 קלט-מערך ספרות המייצג מספר ספרת האחדות בתא האחרון הנחה-גודל המערך מספיק הפעולה מוסיפה 1 למספר המיוצג במערך
// 2 קלט-מערך ספרות המייצג מספר ספרת האחדות בתא האחרו הנחה-גודל המערך מספיק הפעולה מפחיתה 1 מהמספר המיוצג במערך
// 3 הפעולה מקבלת מערך שלמים הפעולה משנה כל איבר שגדול מהשניים הצמודים לו להפרש שבין מספרים אלו
// 4 הפעולה מזיזה את המערך ימינה בצורה מעגלית
// 5 הפעולה מזיזה את המערך שמאלה בצורה מעגלית
// 6 הפעולה מזיזה את המערך מספר מקומות ימינה,לפי הפרמטר,בצורה מעגלית
// 7 נתון מערך ממויין עם כפילויות יש לשנות ערכים כפולים לערך הכי קטן האפשרי כך שלא יהיו כפילויות וגם סדר המיון ישמר
// 8 הפעולה מקבלת מערך ובו ספרות 0 ו 1 בלבד הפעולה מעבירה להתחלה את כל האפסים ואחריהם יהיו האחדות
// 9 הפעולה מקבלת מערך מספרים ומעבירה את כל האפסים להתחלה.שאר המספרים שומרים על הסדר
// 10 הפעולה הופכת את סדר האיברים במערך
public class Dim3 {

    public static void main(String[] args) {

    }

    /* 1 - plusOne(int[] digits) */
    // add 1 to number represent in digits arr
    // digitd[0] = 0
    /*
     * 1 - plusOne(int[] digits)
     * -> before plusOne([0, 1, 2, 3, 4, 5, 6, 7])
     * after plusOne [0, 1, 2, 3, 4, 5, 6, 8]
     * -> before plusOne([0, 1, 2, 3, 4, 0, 0, 0])
     * after plusOne [0, 1, 2, 3, 4, 0, 0, 1]
     * -> before plusOne([0, 1, 2, 3, 4, 9, 9, 9])
     * after plusOne [0, 1, 2, 3, 5, 0, 0, 0]
     * -> before plusOne([0, 0, 9, 9, 9, 9, 9, 9])
     * after plusOne [0, 1, 0, 0, 0, 0, 0, 0]
     * -> before plusOne([1, 0, 0, 0, 0, 0, 0, 0])
     * after plusOne [1, 0, 0, 0, 0, 0, 0, 1]
     */
    public static void plusOne(int[] digits) {

    }

    /* 2 - minusOne(int[] digits) */
    // substruct 1 from number represent in digits arr
    /*
     * 2 - minusOne(int[] digits)
     * -> before minusOne([0, 1, 2, 3, 4, 5, 6, 8])
     * after minusOne [0, 1, 2, 3, 4, 5, 6, 7]
     * -> before minusOne([0, 1, 2, 3, 4, 0, 0, 1])
     * after minusOne [0, 1, 2, 3, 4, 0, 0, 0]
     * -> before minusOne([0, 1, 2, 3, 5, 0, 0, 0])
     * after minusOne [0, 1, 2, 3, 4, 9, 9, 9]
     * -> before minusOne([0, 1, 0, 0, 0, 0, 0, 0])
     * after minusOne [0, 0, 9, 9, 9, 9, 9, 9]
     * -> before minusOne([1, 0, 0, 0, 0, 0, 0, 1])
     * after minusOne [1, 0, 0, 0, 0, 0, 0, 0]
     */
    public static void minusOne(int[] digits) {

    }

    /* 3 - changeBiggerToDiff(int[] arr) */
    // change any member that is bigger than prev and next
    // to the difference of prev and next
    /*
     * 3 - changeBiggerToDiff(int[] digits)
     * -> before changeBiggerToDiff([0, 8, 2, 3, 4, 6, 9, 7])
     * after changeBiggerToDiff [0, 2, 2, 3, 4, 6, 1, 7]
     */
    public static void changeBiggerToDiff(int[] arr) {

    }

    /* 4 - shiftRight(int[] arr) */
    // move each member 1 place Right, cyclically
    /*
     * 4 - shiftRight(int[] arr)
     * -> before shiftRight([0, 1, 2, 3, 4, 5, 6, 7])
     * after shiftRight [7, 0, 1, 2, 3, 4, 5, 6]
     */
    public static void shiftRight(int[] arr) {

    }

    /* 5 - shiftLeft(int[] arr) */
    // move each member 1 place left, cyclically
    /*
     * 5 - shiftLeft(int[] arr)
     * -> before shiftLeft([7, 0, 1, 2, 3, 4, 5, 6])
     * after shiftLeft [0, 1, 2, 3, 4, 5, 6, 7]
     */
    public static void shiftLeft(int[] arr) {

    }

    /* 6 - rotateRight(int[] arr, int n) */
    // move each member n places right, cyclically
    /*
     * 6 - rotateRight(int[] arr, int k)
     * -> before rotateRight([0, 1, 2, 3, 4, 5, 6, 7], 3)
     * after rotateRight [5, 6, 7, 0, 1, 2, 3, 4]
     * -> before rotateRight([5, 6, 7, 0, 1, 2, 3, 4], 8)
     * after rotateRight [5, 6, 7, 0, 1, 2, 3, 4]
     * -> before rotateRight([5, 6, 7, 0, 1, 2, 3, 4], 10)
     * after rotateRight [3, 4, 5, 6, 7, 0, 1, 2]
     */
    public static void rotateRight(int[] arr, int n) {

    }

    /* 7 - changeValues(int[] sorted) */
    // givven sorted arr (can be with duplications, change every duply
    // to the smallest bigger num of its duply, that is not in arr
    // result arr - can be not sorted
    /*
     * 7 - changeValues(int[] arr)
     * -> before changeValues([1, 2, 2, 2, 3, 3, 5, 7, 6])
     * after changeValues [1, 2, 4, 8, 3, 9, 5, 7, 6]
     */

    public static void changeValues(int[] sorted) {

    }

    /* 8 - segregate0and1(int[] arr) */
    // givven arr of 0 and 1 - move all 0 to start and all 1 to end
    /*
     * -> before segregate0and1([1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1])
     * after segregate0and1 [0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1]
     */
    public static void segregate0and1(int[] arr) {

    }

    /* 9 - moveZerosToLeft(int[] arr) */
    // move all zeros to left, keep arr oreder
    /*
     * 9 - moveZerosToLeft(int[] arr)
     * -> before moveZerosToLeft([5, 0, 2, 0, 3, 0, 0, 4, 6])
     * after moveZerosToLeft [0, 0, 0, 0, 5, 2, 3, 4, 6]
     */
    public static void moveZerosToLeft(int[] arr) {

    }

    /* 10 - reverse(int[] arr) */
    // reverse the array - dont use help array
    /*
     * 10 - reverse(int[] arr)
     * -> before reverse([1, 2, 3, 4, 5, 6])
     * after reverse [6, 5, 4, 3, 2, 1]
     * -> before reverse([1, 2, 4, 5, 6])
     * after reverse [6, 5, 4, 2, 1]
     */
    public static void reverse(int arr[]) {

    }

}
