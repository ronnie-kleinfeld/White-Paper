import java.util.Arrays;

public class Short {
    public static void main(String[] args) {
        Short short1 = new Short();
        System.out.println(short1.toString());
        short1.Ascii();
    }

    // מאפיינים
    private char letter; // """
    private String name; // null
    private int age; // 0
    private double height; // 0.0
    private boolean exists; // false
    private int[] numbers = new int[4]; // [0, 0, 0, 0]
    private String[] names = new String[4]; // [null, null, null, null]
    // private int[] numbers = new int[] { 1, 2, 3, 4, 5 }; // [1, 2, 3, 4, 5]
    // private String[] names = new String[] { "Ronnie", "Shira", "Roy", "Yahli" };
    // // [Ronnie, Shira, Roy, Yahli]

    // בנאי ריק
    public Short() {
    }

    // בנאי חלקי
    public Short(char letter, String name, int age) {
        this.letter = letter;
        this.name = name;
        this.age = age;
    }

    // בנאי מלא
    public Short(char letter, String name, int age, double height, boolean exists, int[] numbers, String[] names) {
        this.letter = letter;
        this.name = name;
        this.age = age;
        this.height = height;
        this.exists = exists;
        this.numbers = numbers;
        this.names = names;
    }

    public String toString() {
        String result = letter + "\n";
        result += name + "\n";
        result += age + "\n";
        result += height + "\n";
        result += exists + "\n";
        result += Arrays.toString(numbers) + "\n";
        result += Arrays.toString(names);
        return result;
    }

    public void println() {
        System.out.println("Yahli"); // Yahli
        System.out.println("Yahli\"\\"); // Yahli"\
        System.out.print("Yahli"); // Yahli NOT go to new line
        System.out.println("Yahli" + 11); // Yahli11
        System.out.println(22 + 33); // 55
    }

    // comment
    /*
     * multiline comment
     */

    public void Ascii() {
        char a = 'a';
        System.out.println(a); // a
        System.out.println((int) a); // 97
        System.out.println('a'); // a
    }
}