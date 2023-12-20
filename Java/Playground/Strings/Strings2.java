package Strings;

/**
 * Main class of the Java program.
 * 
 */

public class Strings2 {

    public static void main(String[] args) {

        System.out.println("\nEx1: palindromeStr");
        String st11 = "sdfds";
        System.out.println("palindromeStr(sdfds): " + palindromeStr(st11));

        String st12 = "sdds";
        System.out.println("palindromeStr(sdds): " + palindromeStr(st12));

        String st13 = "sdfdr";
        System.out.println("palindromeStr(sdfds): " + palindromeStr(st13));

        System.out.println("\nEx2: deletestrInStr");
        String st21 = "abcababfgab", st22 = "ab";
        System.out.println("deletestrInStr(abcababfgab, ab): " + deletestrInStr(st21, st22));

        System.out.println("\nEx3: strInStr");
        System.out.println("strInStr(abcababfgab, ab): " + strInStr(st21, st22));

        System.out.println("\nEx4: intersection");
        String st41 = "abbccddeeeef", st42 = "cbjybfffp";
        System.out.println("intersection(abbccddeeeef, cbjybfffp): " + intersection(st41, st42));

        System.out.println("\nEx5: union");
        System.out.println("union(abbccddeeeef, cbjybfffp): " + union(st41, st42));

        System.out.println("\nEx6: checkingProperBrackets");
        String st6 = "3 + 4 + ( 5 + 6 + ( 7 + ( 8 + 9 ) + ( 9 + 7) ) + 10 )";
        System.out.println("checkingProperBrackets(3 + 4 + ( 5 + 6 + ( 7 + ( 8 + 9 ) + ( 9 + 7) ) + 10 )): "
                + checkingProperBrackets(st6));

        System.out.println("\nEx7: smallest");
        String st7 = "yfrbdeko";
        System.out.println("smallest(yfrbdeko): " + smallest(st7));

        System.out.println("\nEx8: missingLetters");
        String st8 = "yfrbdejkrtyssxmnko";
        System.out.println("missingLetters(yfrbdejkrtyssxmnko): " + missingLetters(st8));

        System.out.println("\nEx9: longestCommonSubstr");
        String st91 = "rtydfgo";
        String st92 = "Superfgtrrr";
        System.out.println("longestCommonSubstr(yfrbdejkrtyssxmnko): " + longestCommonSubstr(st91, st92));

        st91 = "Antidisestablishmentarianism";
        st92 = "Supercalifragilisticexpialidocious";
        System.out.println("longestCommonSubstr(yfrbdejkrtyssxmnko): " + longestCommonSubstr(st91, st92));

    }

    // exercise 1
    // returns true if str if palindrome
    // abcdcba true, abccba true, abc false, abab false
    public static boolean palindromeStr(String str) {
        return false;
    }

    // exercise 2
    // remove all str2 instances from str1
    // deletestrInStr(ababababababbbaa, ab) : bbaa
    // deletestrInStr(bbbaabbbbabbba, bbb) : baaaba
    public static String deletestrInStr(String str1, String str2) {
        return "-999";
    }

    // exercise 3
    // return how many str2 instances in str1
    // strInStr(ababababababbbaa, ab)? : 6
    // strInStr(bbbaabbbbabbba, bb)? : 7
    public static int strInStr(String str1, String str2) {
        return -999;
    }

    // exercise 4
    // return intersection of chars in strings (chars in both str1 && str2)
    // intersection(dafna levi, dana levko)? : dan lev
    public static String intersection(String str1, String str2) {
        return "-999";
    }

    // exercise 5
    // return union of chars in strings (chars in both str1 || str2)
    // union(dafna levi, dana levko)? : dafn leviko
    public static String union(String str1, String str2) {
        return "-999";
    }

    // exercise 6
    // receives a string that is an algebraic expression
    // return true if the parentheses in the string are correct, false otherwise
    // 3 + 4 + ( 5 + 6 + ( 7 + ( 8 + 9 ) ) + 10 ) return true
    // 3 + 4 + ( 5 + 6 + 7 + ( 8 + 9 ) ) + 10 ) return false
    // 3 + 4 + ( 5 + 6 + ( 7 + ( 8 + 9 ) + ( 9 + 7) ) + 10 ) return true
    public static boolean checkingProperBrackets(String str) {
        return false;
    }

    // exercise 7
    // str is not empty
    // returns the "smallest" char (a"b- a before b) in str
    public static char smallest(String str) {
        return '$';
    }

    // exercise 8
    // returns string of all abc letters that are not in str
    // missingLetters(zxybmn) : acdefghijklopqrstuvw
    public static String missingLetters(String str) {
        return "-999";
    }

    // exercise 9
    // returns length of longest common substring in str1, str2
    // dafna, afn = 3
    // dafna, cats = 0
    public static int longestCommonSubstr(String str1, String str2) {
        return -999;
    }
}
