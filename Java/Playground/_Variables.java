import java.util.Date;

public class _Variables {
    public static void main(String[] args) {
        System.out.println("Variables");

        int age = 30;
        System.out.println(age); // 30

        age = 35;
        System.out.println(age); // 35

        int age2 = age;
        System.out.println(age2); // 35

        // primitive types
        byte floor = 30;
        int number = 12345;
        long count = 3123456789L; // L
        double multiple = 5.44;
        float price = 10.99F; // F
        char letter = 'R';
        boolean canVote = true; // false

        // reference types
        Date now = new Date();
        System.out.println(now); // Thu Nov 02 18:38:10 IST 2023
    }
}
