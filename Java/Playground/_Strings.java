public class _Strings {
    public static void main(String[] args) {
        String message = "Hello World";
        System.out.println(message); // Hello World

        System.out.println(message + " Ronnie"); // Hello World Ronnie

        System.out.println(message.length()); // 11

        System.out.println(message.startsWith("H"));
        System.out.println(message.startsWith("Yahli")); // false

        System.out.println(message.indexOf("Y")); // -1
        System.out.println(message.indexOf("o")); // 4

        System.out.println(message.toUpperCase());
        System.out.println(message.indexOf("HELLO"));
        System.out.println(message.toUpperCase().indexOf("HELLO"));

        System.out.println(message); // Hello World

        System.out.println(message.substring(3, 5)); // lo
        System.out.println(message.substring(6, 9)); // wor

        System.out.println("Ronnie: \"Kleinfeld\""); // Ronnie: "Kleinfeld"
        // \" - "
        // \\ - \
        // \n - new line
        // \t - tab

        message = "How are you";
        String input = "are";
        System.out.println(message.indexOf(input)); // 4

        input = "ARE";
        System.out.println(message.indexOf(input)); // -1
    }
}
