package Dim;

/**
 * Main class of the Java program.
 * 
 */

// output
// 1-print int Array[3,6,8,12,-4,34,0]2-print double Array
// BackWord[34.32,-4.0,12.123,8.09,6.76,3.4]
// 3-print char Array-first half[d,r]
// 4-print String Array-only even indexes[we,are,the,champions]
// 5-sum Array[1,4,2,1,3]sum Array:11
// 6-avg Array avg Array:2.2
// 6-is Member isMember 3?:true isMember 7?:false
// 8-all Members off arr1 In arr2 arr1:[2,5,7,3,9,4]arr2:[7,5,8,4,2,13,9,3]all
// Members off arr1 In arr2:true all Members off arr2 In arr1:false
// 9-different Arrays-no common member
// arr3:[1,2,3,4,5,6]arr4:[7,8,9,10]arr5:[7,8,2,9,10]different arrays
// arr3,arr4:true different arrays arr4,arr5:false
// 10-same members
// arr6:[1,2,3,4,5,6]arr7:[1,2,4,6,1,1,1,3,4,5,6]arr8:[1,2,3,7,5,6,4]same
// members arr6,arr7:true same members arr6,arr8:false
public class Dim1 {
    // 1. כתבו פעולה המקבלת מערך שלמים ומדפיסה אותו במבנה: [1, 2, 3, 4]. שימו לב
    // לפסיק אחרי כל אחד למעט האחרון ולרווח אחרי פסיק.
    // 2. המקבלת מערך מספרים עשרוניים ומדפיסה אותו מהסוף להתחלה במבנה: [1.0 ,2.0
    // ,3.0 ,4.0]. שימו לב לפסיק אחרי כל אחד למעט האחרון ולרווח אחרי פסיק.וח אחרי
    // פסיק.
    // 3. כתבו פעולה המקבלת מערך תווים ומדפיסה את המחצית הראשונה שלו:
    // {a,b,c,d,e}: יודפס [a, b]
    // {a,b,c,d}: יודפס [a, b]
    // 4. כתבו פעולה המקבלת מערך מחרוזות ומדפיסה את האיברים במיקומים הזוגיים:
    // {a,b,c,d,e}: יודפס [a, c, e]
    // {a,b,c,d}: יודפס [a, c]
    // 5. כתבו פעולה המקבלת מערך מספרים שלמים ומחזירה את סכום האיברים.
    // 6. כתבו פעולה המקבלת מערך מספרים שלמים ומחזירה את ממוצע האיברים.
    // 7. כתבו פעולה המקבלת מערך מספרים שלמים ומספר ומחזירה אמת אם המספר נמצא במערך
    // ושקר אחרת.
    // 8. כתבו פעולה המקבלת שני מערכים של מספרים שלמים ומחזירה אמת אם כל איברי המערך
    // הראשון נמצאים במערך השני ושקר אחרת.
    // 9. כתבו פעולה המקבלת שני מערכים של מספרים שלמים ומחזירה אמת אין במערכים
    // איברים משותפים ושקר אחרת.
    // 10. כתבו פעולה המקבלת שני מערכים של מספרים שלמים ומחזירה אמת אם כל איברי
    // המערכים משותפים (כל איבר באחד המערכים נמצא גם בשני) ושקר אחרת.
    // 1. כתבו פעולה המקבלת מערך שלמים ומדפיסה אותו במבנה: [1, 2, 3, 4]. שימו לב
    // לפסיק אחרי כל אחד למעט האחרון ולרווח אחרי פסיק.
    // 2. המקבלת מערך מספרים עשרוניים ומדפיסה אותו מהסוף להתחלה במבנה: [1.0 ,2.0
    // ,3.0 ,4.0]. שימו לב לפסיק אחרי כל אחד למעט האחרון ולרווח אחרי פסיק.וח אחרי
    // פסיק.
    // 3. כתבו פעולה המקבלת מערך תווים ומדפיסה את המחצית הראשונה שלו:
    // {a,b,c,d,e}: יודפס [a, b]
    // {a,b,c,d}: יודפס [a, b]
    // 4. כתבו פעולה המקבלת מערך מחרוזות ומדפיסה את האיברים במיקומים הזוגיים:
    // {a,b,c,d,e}: יודפס [a, c, e]
    // {a,b,c,d}: יודפס [a, c]
    // 5. כתבו פעולה המקבלת מערך מספרים שלמים ומחזירה את סכום האיברים.
    // 6. כתבו פעולה המקבלת מערך מספרים שלמים ומחזירה את ממוצע האיברים.
    // 7. כתבו פעולה המקבלת מערך מספרים שלמים ומספר ומחזירה אמת אם המספר נמצא במערך
    // ושקר אחרת.
    // 8. כתבו פעולה המקבלת שני מערכים של מספרים שלמים ומחזירה אמת אם כל איברי המערך
    // הראשון נמצאים במערך השני ושקר אחרת.
    // 9. כתבו פעולה המקבלת שני מערכים של מספרים שלמים ומחזירה אמת אין במערכים
    // איברים משותפים ושקר אחרת.
    // 10. כתבו פעולה המקבלת שני מערכים של מספרים שלמים ומחזירה אמת אם כל איברי
    // המערכים
    // משותפים (כל איבר באחד המערכים נמצא גם בשני) ושקר אחרת.
    public static void main(String[] args) {

        System.out.println("\n1 - print int Array");
        int[] a1 = { 3, 6, 8, 12, -4, 34, 0 };
        print(a1);

        System.out.println("\n2 - print double Array BackWord");
        double[] a2 = { 3.4, 6.76, 8.09, 12.123, -4.0, 34.32, 0 };
        printBackWord(a2);

        System.out.println("\n3 - print char Array - first half");
        char[] a3 = { 'd', 'r', 's', 'd', 'r' };
        printHalf(a3);

        System.out.println("\n4 - print String Array - only even indexes");
        String[] a4 = { "we", "you", "are", "red", "the", "black", "champions", "no" };
        printEvenIndexes(a4);

        System.out.println("\n5 - sum Array");
        int[] a5 = { 1, 4, 2, 1, 3 };
        print(a5);
        System.out.println("sum Array : " + sum(a5));

        System.out.println("\n6 - avg Array");
        System.out.println("avg Array : " + avg(a5));

        System.out.println("\n6 - is Member");
        System.out.println("isMember 3? : " + isMember(a5, 3));
        System.out.println("isMember 7? : " + isMember(a5, 7));

        System.out.println("\n8 - all Members off arr1 In arr2");
        int[] arr1 = { 2, 5, 7, 3, 9, 4 };
        System.out.print("arr1 : ");
        print(arr1);
        int[] arr2 = { 7, 5, 8, 4, 2, 13, 9, 3 };
        System.out.print("arr2 : ");
        print(arr2);
        System.out.println("all Members off arr1 In arr2 : " + allMembersIn(arr1, arr2));
        System.out.println("all Members off arr2 In arr1 : " + allMembersIn(arr2, arr1));

        System.out.println("\n9 - different Arrays - no common member");
        int[] arr3 = { 1, 2, 3, 4, 5, 6 };
        System.out.print("arr3 : ");
        print(arr3);
        int[] arr4 = { 7, 8, 9, 10 };
        System.out.print("arr4 : ");
        print(arr4);
        int[] arr5 = { 7, 8, 2, 9, 10 };
        System.out.print("arr5 : ");
        print(arr5);
        System.out.println("different arrays arr3, arr4: " + different(arr3, arr4));
        System.out.println("different arrays arr4, arr5: " + different(arr4, arr5));

        System.out.println("\n10 - same members");
        int[] arr6 = { 1, 2, 3, 4, 5, 6 };
        System.out.print("arr6 : ");
        print(arr6);
        int[] arr7 = { 1, 2, 4, 6, 1, 1, 1, 3, 4, 5, 6 };
        System.out.print("arr7 : ");
        print(arr7);
        int[] arr8 = { 1, 2, 3, 7, 5, 6, 4 };
        System.out.print("arr8 : ");
        print(arr8);
        System.out.println("same members arr6, arr7: " + sameMembers(arr6, arr7));
        System.out.println("same members arr6, arr8: " + sameMembers(arr6, arr8));

    }

    /* 1 - print int Array */
    public static void print(int[] arr) {

    }

    /* 2 - print double Array BackWord */
    public static void printBackWord(double[] arr) {

    }

    /* 3 - print char Array - first half */
    public static void printHalf(char[] arr) {

    }

    /* 4 - print String Array - only even indexes */
    public static void printEvenIndexes(String[] arr) {

    }

    /* 5 - sum Array */
    // [1, 4, 2, 1, 3]
    // return : 11
    public static int sum(int[] arr) {

        return -999;
    }

    /* 6 - avg Array */
    // [1, 4, 2, 1, 3]
    // return : 2.2
    public static double avg(int[] arr) {
        return -999;
    }

    /* 7 - is member */
    // int[] a1 = {3,6,8,12,-4,34,0};
    // isMember(a1,12) return true
    // isMember(a1,33) return false
    public static boolean isMember(int[] arr, int num) {
        return false;

    }

    /* 8 - all Members off arr1 In arr2 */
    public static boolean allMembersIn(int[] arr1, int[] arr2) {

        return false;
    }

    /* 9 - different arrays (no common member) */
    public static boolean different(int[] arr1, int[] arr2) {

        return false;
    }

    /* 10 - same members */
    public static boolean sameMembers(int[] arr1, int[] arr2) {

        return false;
    }

}
