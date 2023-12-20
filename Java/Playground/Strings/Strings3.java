package Strings;

/**
 * Main class of the Java program.
 * 
 */

public class Strings3 {

    public static void main(String[] args) {

        System.out.println("\nEx1: maximumDifferenceBetweenDigits");
        System.out.println("maximumDifferenceBetweenDigits(gh2bg7e5fd1p): " +
                maximumDifferenceBetweenDigits("gh2bg7e5fd1p"));
        System.out.println("maximumDifferenceBetweenDigits(yut6a32): " +
                maximumDifferenceBetweenDigits("yut6a32"));
        System.out.println("maximumDifferenceBetweenDigits(abc): " +
                maximumDifferenceBetweenDigits("abc"));
        System.out.println("maximumDifferenceBetweenDigits(a1): " +
                maximumDifferenceBetweenDigits("a1"));

        System.out.println("\nEx2: maximumDistanceBetweenLetters");
        System.out.println("maximumDistanceBetweenLetters(&^6al@@nb&7): " +
                maximumDistanceBetweenLetters("&^6al@@nb&7"));
        System.out.println("maximumDistanceBetweenLetters(1ab): " +
                maximumDistanceBetweenLetters("1ab"));
        System.out.println("maximumDistanceBetweenLetters(1a): " +
                maximumDistanceBetweenLetters("a"));
        System.out.println("maximumDistanceBetweenLetters(11): " +
                maximumDistanceBetweenLetters("11"));

        System.out.println("\nEx3: isSubString");
        System.out.println("isSubString(dafna, afna): " +
                isSubString("dafna", "afna"));
        System.out.println("isSubString(dafna, afnda): " +
                isSubString("dafna", "afnda"));
        System.out.println("isSubString(dafna, \"\"): " +
                isSubString("dafna", ""));

        System.out.println("\nEx4: caesarCipher");
        String str1 = "ABCDE THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
        System.out.println("String     = " + str1);
        String str2 = caesarCipher(str1, 2);
        System.out.println("cipher(2)  = " + str2);
        System.out.println("String     = " + str2);
        String str3 = caesarCipher(str2, -2);
        System.out.println("cipher(-2) = " + str3);

        System.out.println("String     = " + str1);
        str2 = caesarCipher(str1, 27);
        System.out.println("cipher(27) = " + str2);
        System.out.println("String     = " + str2);
        str3 = caesarCipher(str2, -27);
        System.out.println("cipher(-27)= " + str3);

        System.out.println("\nEx5: sort");
        String words = "Green White Black Pink Orange Blue Champagne Indigo Ivory";
        System.out.println("String = " + words);
        System.out.println("Sort   = " + sort(words));

    }

    // 1
    // returns max difference between two digits in str (or 0)
    // str = "ayg5n3hh27yj" -> 5 (7-2)
    // str = "ay8g5n3hh27yj1" -> 7 (8-1)
    // str = "lhg" -> 0
    public static int maximumDifferenceBetweenDigits(String str) {

        return -999;
    }

    // 2
    // returns max distance between two abc letters in str (or 0)
    // str = "ayg5n3hh27yj" -> 5 (7-2)
    // str = "ay8g5n3hh27yj1" -> 7 (8-1)
    // str = "lhg" -> -1
    public static int maximumDistanceBetweenLetters(String str) {

        return -999;
    }

    // 3
    // return true if str2 is subString of str1
    // str1 = abcde str2 = "", a, b, c... ab, abc, bc,... bcd, bcde etc.
    public static boolean isSubString(String str1, String str2) {

        return false;
    }

    // 4
    // Write a method to create a Caesar encryption.
    // Note: In cryptography, a Caesar cipher, also known as Caesar's cipher,
    // the shift cipher, Caesar's code or Caesar shift,
    // is one of the simplest and most widely known encryption techniques.
    // It is a type of substitution cipher in which each letter in the plaintext
    // is replaced by a letter some fixed number of positions down the alphabet.
    // For example, with a left shift of 3, D would be replaced by A, E would become
    // B,
    // and so on. The method is named after Julius Caesar, who used it in his
    // private correspondence.
    public static String caesarCipher(String str, int shift) {

        return "###";
    }

    // 5
    // sort words in String, a"b order
    // in String = Green White Black Pink Orange Blue Champagne Indigo Ivory
    // Sort = Black Blue Champagne Green Indigo Ivory Orange Pink White
    public static String sort(String words) {

        return null;
    }

    // you may write help method :
    private static String insertInPlace(String sorted, String word) {

        return null;
    }
}
