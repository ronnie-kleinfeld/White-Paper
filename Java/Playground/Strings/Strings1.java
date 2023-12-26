package Strings;

/**
 * Main class of the Java program.
 * 
 */

public class Strings1 {

    public static void main(String[] args) {
        System.out.println("Ex1: changeID");
        String id = "123456789";
        String newId = changeID(id);
        System.out.println("Old ID: " + id);
        System.out.println("New ID: " + newId);

        System.out.println("\nEx2: countInstances");
        String str = "hello world";
        char ch = 'o';
        int count = countInstances(str, ch);
        System.out.println("Number of instances of '" + ch + "' in '" + str + "': " + count);

        System.out.println("\nEx3a: printStairsFromStart");
        String input = "hello";
        printStairsFromStart(input);

        System.out.println("\nEx3b: printStairsFromStartEnd");
        printStairsFromEnd(input);

        System.out.println("\nEx4: similarPairOfStrings");
        String str1 = "hello";
        String str2 = "holla";
        boolean result = similarPairOfStrings(str1, str2);
        System.out.println("Are '" + str1 + "' and '" + str2 + "' similar? " + result);

        System.out.println("\nEx5: doubleCharacters");
        String str3 = " BCKLMN A ,";
        String result2 = doubleCharacters(str3);
        System.out.println("Doubled characters of '" + str3 + "': " + result2);

        System.out.println("\nEx6: reverseString");
        String str4 = " BCKLMN A ,";
        String result3 = reverseString(str4);
        System.out.println("Reverse of '" + str4 + "': " + result3);

        System.out.println("\nEx7: withoutSpaces");
        String str5 = " BCKLMN A ";
        String result4 = withoutSpaces(str5);
        System.out.println("Without spaces of '" + str5 + "': " + result4);

        System.out.println("\nEx8: withoutDuplicateChars");
        String str6 = "ZZOOOPSTUUVWW ";
        String result5 = withoutDuplicateChars(str6);
        System.out.println("Without duplicates of '" + str6 + "': " + result5);

        System.out.println("\nEx9: withoutDuplicates");
        String str7 = "ZUVZOOOPSTUUVWOW ";
        String result6 = withoutDuplicates(str7);
        System.out.println("Without duplicates of '" + str7 + "': " + result6);

        System.out.println("\nEx10: letterToIndex");
        String str8 = "a1b2c3";
        String result7 = letterToIndex(str8);
        System.out.println("Converted string of '" + str8 + "': " + result7);
    }

    /* Ex1 */
    // Following the recent increase in population, the Ministry of Interior has
    // decided to replace the first digit of the ID number with two digits, so that
    // the original ID number will be one digit longer.
    // Write a method called "changeID" that receives an ID number (string) as a
    // parameter. The method will remove the first character and replace it with the
    // last two characters of the ID number. If the first character is an even
    // number, the two characters will be added in order. Otherwise, they will be
    // added in reverse order.
    // If the original ID number is 059147638, the new ID number will be 3859147638.

    // in : digits String
    // return : if first digit is even - it will change to last two digits
    // if odd - it will change to last two digits, but in reverse order
    // in - 059147638, return 3859147638
    // in - 159147638, return 8359147638
    public static String changeID(String idNumber) {

        return null;
    }

    /* Ex2 */
    // Write a function similarPairOfStrings that receives two strings and returns
    // true if they are similar, false otherwise. Two strings are considered similar
    // if they have the same length and start and end with the same characters.

    // in : String1, String2
    // return true : if similar = same length, same first and last characters
    public static boolean similarPairOfStrings(String str1, String str2) {

        return false;
    }

    /* Ex3 */
    // Write a method called "printStairsFromStart" that receives a string and
    // prints it in a graded format from the beginning to the end.

    /*
     * in:hello, print:
     * hello
     * ello
     * llo
     * lo
     * o
     */
    public static void printStairsFromStart(String str) {

    }

    /*
     * in:white, print:
     * e
     * te
     * ite
     * hite
     * white
     */
    public static void printStairsFromEnd(String str) {

    }

    /* Ex4 */
    // Write a method called "countInstances" that receives a string and a
    // character, and returns the number of times the character appears in the
    // string.
    public static int countInstances(String str, char c) {

        return -999;
    }

    /* Ex5 */
    // Write a method called "doubleCharacters" that receives a string and returns a
    // new string with doubled characters.
    // For example, the given string "BCKLMN A,"
    // should return the string "BBCCKKLLMMNN AA"
    public static String doubleCharacters(String str) {

        return null;
    }

    /* Ex6 */
    // Write a method called "reverseString" that receives a string and returns the
    // reverse of that string.
    // For example, the given string "BCKLMN A,"
    // should return the string "A NMLKCB"
    public static String reverseString(String str) {

        return null;
    }

    /* Ex7 */
    // Write a method called withoutSpaces that receives a string and returns a new
    // string without any spaces.
    // For example, the input string "BCKLMN A" should return "ABCKLMN".
    public static String withoutSpaces(String str) {

        return null;
    }

    /* Ex8 */
    // Write a method withoutDuplicateChars that receives a String and returns a new
    // String where every character that appears more than once in a row is replaced
    // by an asterisk (*).
    public static String withoutDuplicateChars(String str) {
        String result = "";

        result = result + str.charAt(0);

        for (int i = 1; i < str.length(); i++) {
            char prev = str.charAt(i - 1);
            char curr = str.charAt(i);

            if (curr == prev) {
                result = result + "*";
            } else {
                result = result + curr;
            }
        }

        return result;
    }

    /* Ex9 */
    // write a function 'withoutDuplicates' that receives a string and returns a
    // string with only unique characters.
    // The order of the characters in the resulting string does not matter.

    public static String withoutDuplicates(String str) {
        String result = "";

        for (int i = 0; i < str.length(); i++) {
            char temp = str.charAt(i);

            if (result.indexOf(temp) == -1) {
                result = result + temp;
            }
        }

        return result;
    }

    /* Ex10 */
    // Write a function 'letterToIndex' that receives a string and returns a new
    // string
    // where every letter is replaced with its index in the input string.
    // Non-letter characters should be kept as-is.
    //
    // For example: "a1b2c3" should be converted to "012345"
    public static String letterToIndex(String str) {
        System.out.println("0123456789".indexOf(temp));

        return "";
    }

}
