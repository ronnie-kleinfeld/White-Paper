/**
 * Main class of the Java program. 
 * 
 */

 public class Main {

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
     // Following the recent increase in population, the Ministry of Interior has decided to replace the first digit of the ID number with two digits, so that the original ID number will be one digit longer.
     // Write a method called "changeID" that receives an ID number (string) as a parameter. The method will remove the first character and replace it with the last two characters of the ID number. If the first character is an even number, the two characters will be added in order. Otherwise, they will be added in reverse order.
     // If the original ID number is 059147638, the new ID number will be 3859147638.
     
     // in : digits String
     // return : if first digit is even - it will change to last two digits
     //          if odd - it will change to last two digits, but in reverse order
     // in - 059147638, return 3859147638
     // in - 159147638, return 8359147638
     public static String changeID(String idNumber) {
         
     
         return null;
     }
 
     /* Ex2 */
     // Write a function similarPairOfStrings that receives two strings and returns true if they are similar, false otherwise. Two strings are considered similar if they have the same length and start and end with the same characters.
     
     // in : String1, String2
     // return true : if similar = same length, same first and last characters
     public static boolean similarPairOfStrings(String str1, String str2) {
         boolean similar = false;
         if(str1.length() == str2.length())
             if(str1.charAt(0)==str2.charAt(0))
                 if(str1.charAt(str1.length()-1)==str2.charAt(str2.length()-1))
                     similar = true;
         return similar;
     }
     
     /* Ex3 */
     // Write a method called "printStairsFromStart" that receives a string and prints it in a graded format from the beginning to the end.
     
     /*  in:hello, print:
         hello
         ello
         llo
         lo
         o
     */ 
     public static void printStairsFromStart(String str) {
         for(int i = 0; i<str.length(); i++)
             System.out.println(str.substring(i,str.length()));
             
         
     }
     
     
     /*  in:white, print:
         e
         te
         ite
         hite
         white
     */ 
     public static void printStairsFromEnd(String str){
         for(int i = 0; i < str.length(); i++) {
             System.out.println(str.substring(str.length() - 1 - i));
         }
     }
     
     /* Ex4 */
     // Write a method called "countInstances" that receives a string and a character, and returns the number of times the character appears in the string.
     public static int countInstances(String str, char c) {
         
         return -999;
     }
     
     /* Ex5 */
     // Write a method called "doubleCharacters" that receives a string and returns a new string with doubled characters.
     // For example, the given string "BCKLMN A,"
     // should return the string "BBCCKKLLMMNN AA"
     public static String doubleCharacters(String str) {
         
         return null;
     }
     
     /* Ex6 */
     // Write a method called "reverseString" that receives a string and returns the reverse of that string.
     // For example, the given string "BCKLMN A,"
     // should return the string "A NMLKCB"
     public static String reverseString(String str) {
         
         return null;
     }
     
     /* Ex7 */
     // Write a method called withoutSpaces that receives a string and returns a new string without any spaces. 
     // For example, the input string "BCKLMN A" should return "ABCKLMN".
     public static String withoutSpaces(String str) {
         
         return null;
     }
     
     /* Ex8 */
     // Write a method withoutDuplicateChars that receives a String and returns a new String where every character that appears more than once in a row is replaced by an asterisk (*).
     public static String withoutDuplicateChars(String str) {
         
         return null;
     }
     
     /* Ex9 */
     // write a function 'withoutDuplicates' that receives a string and returns a string with only unique characters.
     // The order of the characters in the resulting string does not matter.
 
     public static String withoutDuplicates(String str) {
         
         return null;
     }
     
     /* Ex10 */
     // Write a function 'letterToIndex' that receives a string and returns a new string
     // where every letter is replaced with its index in the input string.
     // Non-letter characters should be kept as-is.
     //
     // For example: "a1b2c3" should be converted to "012345"
     public static String letterToIndex(String str) {
         
         return null;
     }
     
     
     
 }

 
 /**
 * Main class of the Java program. 
 * 
 */

public class Main {

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
        System.out.println("deletestrInStr(abcababfgab, ab): " + deletestrInStr(st21,st22));
       
       
        System.out.println("\nEx3: strInStr");
        System.out.println("strInStr(abcababfgab, ab): " + strInStr(st21,st22));
        
        
        System.out.println("\nEx4: intersection");
        String st41 = "abbccddeeeef", st42 = "cbjybfffp";
        System.out.println("intersection(abbccddeeeef, cbjybfffp): " + intersection(st41,st42));
        
        
        System.out.println("\nEx5: union");
        System.out.println("union(abbccddeeeef, cbjybfffp): " + union(st41,st42));
        
        System.out.println("\nEx6: checkingProperBrackets");
        String st6 = "3 + 4 + ( 5 + 6 + ( 7 + ( 8 + 9 ) + ( 9 + 7) ) + 10 )";
        System.out.println("checkingProperBrackets(3 + 4 + ( 5 + 6 + ( 7 + ( 8 + 9 ) + ( 9 + 7) ) + 10 )): " + checkingProperBrackets(st6));
        
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
    public static boolean palindromeStr(String str){
        return false;
    }

    // exercise 2
    // remove all str2 instances from str1
    // deletestrInStr(ababababababbbaa, ab) : bbaa
    // deletestrInStr(bbbaabbbbabbba, bbb) : baaaba
    public static String deletestrInStr(String str1, String str2){
        return "-999";
    }

    // exercise 3
    // return how many str2 instances in str1
    // strInStr(ababababababbbaa, ab)? : 6
    // strInStr(bbbaabbbbabbba, bb)? : 7
    public static int strInStr(String str1, String str2){
        return -999;
    }

    // exercise 4
    // return intersection of chars in strings (chars in both str1 && str2)
    // intersection(dafna levi, dana levko)? : dan lev
    public static String intersection(String str1, String str2){
        return "-999";
    }

    // exercise 5
    // return union of chars in strings (chars in both str1 || str2)
    // union(dafna levi, dana levko)? : dafn leviko
    public static String union(String str1, String str2){
        return "-999";
    }

    // exercise 6
    // receives a string that is an algebraic expression
    // return true if the parentheses in the string are correct, false otherwise
    // 3 + 4 + ( 5 + 6 + ( 7 + ( 8 + 9 ) ) + 10 ) return true
    // 3 + 4 + ( 5 + 6 +  7 + ( 8 + 9 ) ) + 10 ) return false
    // 3 + 4 + ( 5 + 6 + ( 7 + ( 8 + 9 ) + ( 9 + 7) ) + 10 ) return true
    public static boolean checkingProperBrackets(String str){
        return false;
    }
    
    // exercise 7
    // str is not empty
    // returns the "smallest" char (a"b- a before b) in str
    public static char smallest(String str){
        return '$';
    }
    
    // exercise 8
    // returns string of all abc letters that are not in str
    // missingLetters(zxybmn) : acdefghijklopqrstuvw
    public static String missingLetters(String str){
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


/**
 * Main class of the Java program. 
 * 
 */

 public class Main {

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
    
    //1
    // returns max difference between two digits in str (or 0)
    // str = "ayg5n3hh27yj" -> 5 (7-2)
    // str = "ay8g5n3hh27yj1" -> 7 (8-1)
    // str = "lhg" -> 0
    public static int maximumDifferenceBetweenDigits(String str){
		
		return -999;
	}

    

    //2
    // returns max distance between two abc letters in str (or 0)
    // str = "ayg5n3hh27yj" -> 5 (7-2)
    // str = "ay8g5n3hh27yj1" -> 7 (8-1)
    // str = "lhg" -> -1
	public static int maximumDistanceBetweenLetters(String str){
		
		return -999;
	}

    //3
    // return true if str2 is subString of str1
    // str1 = abcde str2 = "", a, b, c... ab, abc, bc,... bcd, bcde etc.
	public static boolean isSubString(String str1, String str2){
	    
		return false;
	}
	
	//4
	// Write a method to create a Caesar encryption.
    // Note: In cryptography, a Caesar cipher, also known as Caesar's cipher, 
    // the shift cipher, Caesar's code or Caesar shift, 
    // is one of the simplest and most widely known encryption techniques. 
    // It is a type of substitution cipher in which each letter in the plaintext 
    // is replaced by a letter some fixed number of positions down the alphabet. 
    // For example, with a left shift of 3, D would be replaced by A, E would become B, 
    // and so on. The method is named after Julius Caesar, who used it in his private correspondence.
	public static String caesarCipher(String str, int shift){
        
        return "###";
    }

    
    
    // 5
    // sort words in String, a"b order 
    // in String = Green White Black Pink Orange Blue Champagne Indigo Ivory
    // Sort      = Black Blue Champagne Green Indigo Ivory Orange Pink White
    public static String sort(String words){
        
        return null;
    }

    // you may write help method : 
    private static String insertInPlace(String sorted, String word){
        
        return null;
    }   
}


/**
 * Main class of the Java program. 
 * 
 */

 public class Main {

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
    
    //1
    // digit 0-9, opp +,-,*,/
    // str = length 2 - digit, opp, digit : 4+2, 9*4, 9/4, 0-4, etc.,
    // return result 
    // "4+2" -> 6
    // "4-8" -> -4
    // "4*2" -> 8
    // "4/5" -> 0.8
    // "4/0" -> -999999.999999
    public static int solveDigitsMathString(String mathStr)
    {
        return -898;
    }

    //2
    // only one opp in str
    // str =  number, opp, number :5464+332, 89*674, 8989/444, 7680-74, etc.,
    // return result 
    public static int solveSimpleMathString(String mathStr){
        return -898;
    }

    

    //3
    // many opps in str
    // str =  number, opp, number, opp, number :5464+332*7+56, etc.,
    // meaning - ((5464+332)*7)+56
    // return result 
    public static int solveMathString(String mathStr)
    {
        return -898;
    }


    
}


public class Main {

	public static void main(String[] args) {
		
		Necklace n1  = new Necklace();
		Necklace n2  = new Necklace("RRRYYYGGG");
		Necklace n3  = new Necklace("GRRRYYYGG", 3);
		Necklace n4  = new Necklace("GRYGGRYYRGGYRG", 4);
		Necklace n5  = new Necklace("GRYGGRYRGGYRG", 2);
		Necklace n6  = new Necklace("RGGGYYRYYRGR", 3);
		Necklace n7  = new Necklace(6, 2);
		Necklace n8  = new Necklace("GRRRYYYGG", 3);
		Necklace n9  = new Necklace("GRRRYYYGG", 2);
		Necklace n10 = new Necklace("GGYYYRRRG", 3);
		
		
		System.out.println("toString");
		System.out.println("n1 = " + n1.toString());
		System.out.println("n2 = " + n2);
		System.out.println("n3 = " + n3);
		System.out.println("n4 = " + n4);
		System.out.println("n5 = " + n5);
		System.out.println("n6 = " + n6);
		System.out.println("n7 = " + n7);
		
		System.out.println("\naddAtBegin");
		System.out.println("before n7 = " + n7 + "   addAtBegin(RRRR)");
		n7.addAtBegin("RRRR");
		System.out.println("after  n7 = " + n7);
		
		System.out.println("\naddAtEnd");
		System.out.println("before n7 = " + n7 + "   addAtEnd(YRYRG)");
		n7.addAtEnd("YRYRG");
		System.out.println("after  n7 = " + n7);
		
		System.out.println("\nequalColors");
		System.out.println("equalColors? n1 = " + n1 + " : " + n1.equalColors());
		System.out.println("equalColors? n2 = " + n2 + " : " + n2.equalColors());
		System.out.println("equalColors? n3 = " + n3 + " : " + n3.equalColors());
		System.out.println("equalColors? n4 = " + n4 + " : " + n4.equalColors());
		
		System.out.println("\nsymetric");
		System.out.println("symetric? n1 = " + n1 + " : " + n1.symetric());
		System.out.println("symetric? n4 = " + n4 + " : "+ n4.symetric());
		System.out.println("symetric? n5 = " + n5 + " : "+ n5.symetric());
		System.out.println("symetric? n7 = " + n7 + " : "+ n7.symetric());
		
		System.out.println("\nidentical");
		System.out.println("identical?" + "\n\t" + n3 + "\n\t" + n4 + "\n\t" + n3.identical(n4));
		System.out.println("identical?" + "\n\t" + n3 + "\n\t" + n8 + "\n\t" + n3.identical(n8));
		System.out.println("identical?" + "\n\t" + n3 + "\n\t" + n9 + "\n\t" + n3.identical(n9));
		System.out.println("identical?" + "\n\t " + n3 + "\n\t" + n10 + "\n\t" + n3.identical(n10));
		
		System.out.println("\nisGrouped");
		System.out.println("isGrouped("+ n2 + ") ? " + isGrouped(n2));
		System.out.println("isGrouped("+ n3 + ") ? " + isGrouped(n3));
		
		System.out.println("\nsameOrder");
		n2.setTimes(3);
		System.out.println("sameOrder?" + "\n\t" + n2 + "\n\t" + n3 + "\n\t" + sameOrder(n2,n3));
		System.out.println("sameOrder?" + "\n\t" + n8 + "\n\t" + n3 + "\n\t" + sameOrder(n8,n3));
		
		
		
		
		
	}
	
	public static boolean isGrouped(Necklace n1) {
		
		return false;
	}
	
	public static boolean sameOrder(Necklace n1, Necklace n2) {
		
		return false;
	}
	
	

}

import java.util.Random;

public class Necklace {
	
	
	private static Random rnd = new Random(7);
	
	public Necklace() {
	
		
	}
	public Necklace(String beads) {
	
		
	}
	public Necklace(String beads, int times) {
	
		
	}
	public Necklace(int length, int times) {
		
		
	}
	
	
	
	
	
	public String getBeads() {
		return null;
	}
	public void setBeads(String beads) {
		
	}
	public int getTimes() {
		return -1;
	}
	public void setTimes(int times) {
	
	}
	public String toString() {
	
		return null;
	}
	
	public void addAtBegin(String st) {
		
	}
	
	public void addAtEnd(String st) {
		
	}
	
	public boolean equalColors() {
		
		return false;
	}
	
	public boolean symetric() {
		
		return false;
	}
	
	public boolean identical(Necklace n) {

		return false;
	}
	

	
	public String getProduct() {
		return null;
	}
	public static int getCounter() {
		return -1;
	}
	
}
