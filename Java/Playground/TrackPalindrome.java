public class TrackPalindrome {
    public static void main(String[] args) {
        // Original palindrome check
        String input1 = "level";
        boolean isPalindrome1 = checkPalindromeString(input1);
        System.out.println("Is \"" + input1 + "\" a palindrome? " + isPalindrome1);

        // Variation 1: Check palindrome for char array
        char[] input2 = { 'r', 'a', 'c', 'e', 'c', 'a', 'r' };
        boolean isPalindrome2 = checkPalindromeCharArray(input2);
        System.out.println("Is {'r', 'a', 'c', 'e', 'c', 'a', 'r'} a palindrome? " + isPalindrome2);
    }

    // Original palindrome check for String
    public static boolean checkPalindromeString(String input) {
        boolean result = true;
        int length = input.length();

        for (int i = 0; i < length / 2; i++) {
            if (input.charAt(i) != input.charAt(length - i - 1)) {
                result = false;
                break;
            }
        }

        return result;
    }

    // Variation 1: Check palindrome for char array
    public static boolean checkPalindromeCharArray(char[] input) {
        boolean result = true;
        int length = input.length;

        for (int i = 0; i < length / 2; i++) {
            if (input[i] != input[length - i - 1]) {
                result = false;
                break;
            }
        }

        return result;
    }
}