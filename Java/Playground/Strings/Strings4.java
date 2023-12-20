package Strings;

/**
 * Main class of the Java program.
 * 
 */

public class Strings4 {

    public static void main(String[] args) {

        String str1 = "2+5";
        System.out.println(str1 + " = " + solveDigitsMathString(str1));
        String str2 = "2*5";
        System.out.println(str2 + " = " + solveDigitsMathString(str2));
        String str3 = "2/5";
        System.out.println(str3 + " = " + solveDigitsMathString(str3));
        String str4 = "2-5";
        System.out.println(str4 + " = " + solveDigitsMathString(str4));
        String str5 = "2/0";
        System.out.println(str5 + " = " + solveDigitsMathString(str5));
        String str6 = "2s444";
        System.out.println(str6 + " = " + solveDigitsMathString(str6));

        String str11 = "222+544";
        System.out.println(str11 + " = " + solveSimpleMathString(str11));
        String str12 = "222*54";
        System.out.println(str12 + " = " + solveSimpleMathString(str12));
        String str13 = "22/544";
        System.out.println(str13 + " = " + solveSimpleMathString(str13));
        String str14 = "2872-544";
        System.out.println(str14 + " = " + solveSimpleMathString(str14));
        String str15 = "29992/0";
        System.out.println(str15 + " = " + solveSimpleMathString(str15));
        String str16 = "222s4494";
        System.out.println(str16 + " = " + solveSimpleMathString(str16));

        String str = "10/2+5*10-20";
        System.out.println(str + " = " + solveMathString(str));
        String strA = "11/2+5*10-20";
        System.out.println(strA + " = " + solveMathString(strA));
        String strB = "1234";
        System.out.println(strB + " = " + solveMathString(strB));

    }

    // 1
    // digit 0-9, opp +,-,*,/
    // str = length 2 - digit, opp, digit : 4+2, 9*4, 9/4, 0-4, etc.,
    // return result
    // "4+2" -> 6
    // "4-8" -> -4
    // "4*2" -> 8
    // "4/5" -> 0.8
    // "4/0" -> -999999.999999
    public static int solveDigitsMathString(String mathStr) {
        return -898;
    }

    // 2
    // only one opp in str
    // str = number, opp, number :5464+332, 89*674, 8989/444, 7680-74, etc.,
    // return result
    public static int solveSimpleMathString(String mathStr) {
        return -898;
    }

    // 3
    // many opps in str
    // str = number, opp, number, opp, number :5464+332*7+56, etc.,
    // meaning - ((5464+332)*7)+56
    // return result
    public static int solveMathString(String mathStr) {
        return -898;
    }

}
