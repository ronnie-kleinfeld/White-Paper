public class Strings {
    public static void usage() {
        String message = "Hello World";
        System.out.println(message); // Hello World

        System.out.println(message + " Ronnie"); // Hello World Ronnie

        System.out.println(message.length()); // 11

        System.out.println(message.charAt(0)); // H
        System.out.println(message.charAt(4)); // o

        System.out.println(message.startsWith("H"));
        System.out.println(message.startsWith("Yahli")); // false

        System.out.println(message.indexOf("Y")); // -1 לא נמצא
        System.out.println(message.indexOf("o")); // 4
        System.out.println(message.lastIndexOf("o")); // 7

        System.out.println(message.toUpperCase());
        System.out.println(message.indexOf("HELLO"));
        System.out.println(message.toUpperCase().indexOf("HELLO"));

        System.out.println(message); // Hello World

        System.out.println(message.substring(3, 5)); // lo
        System.out.println(message.substring(6, 9)); // wor

        System.out.println("Yahli: \"Kleinfeld\""); // Yahli: "Kleinfeld"
        // \" - "
        // \\ - \
        // \n - new line
        // \t - tab
    }

    public static void ascii() {
        char c1 = 'a';
        System.out.println(c1); // a
        System.out.println((int) c1); // 97
        System.out.println((char) 98); // b
    }
}