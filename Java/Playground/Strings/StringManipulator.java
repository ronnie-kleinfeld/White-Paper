package Strings;

public class StringManipulator {

    public static String withoutDuplicateChars(String input) {
        String result = "";
        char currentChar = input.charAt(0);
        int charCount = 1;

        for (int i = 1; i < input.length(); i++) {
            char nextChar = input.charAt(i);

            if (nextChar == currentChar) {
                charCount++;
            } else {
                result += (charCount > 1 ? '*' : currentChar);
                currentChar = nextChar;
                charCount = 1;
            }
        }

        result += (charCount > 1 ? '*' : currentChar);

        return result;
    }

    public static void main(String[] args) {
        // Example usage:
        String inputString = "ZZOOOPSTUUVWW";
        String result = withoutDuplicateChars(inputString);
        System.out.println(result);
    }
}
