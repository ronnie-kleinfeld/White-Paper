import java.util.Random;

public class Mathematics {
    // a == b
    // a != b
    // a > b
    // a >= b
    // a < b
    // a <= b

    // a > b && b > 0 // and
    // a > b || b < 0 // or

    // אופרטורים
    // ++ num++ num + 1
    // -- num-- num - 1
    // += num+=2 num + 2
    // -= num-=3 num - 3
    // *= num*=4 num * 4
    // /= num/=5 num / 5
    // %= num%=6 num % 6

    public static void usage() {
        double pi = Math.PI; // 3.1415...
        Math.pow(3, 2); // 9.0
        Math.sqrt(9); // 3.0
    }

    public static void round() {
        int i1 = 5; // 5
        double d1 = 5.0; // 5.0

        // 5/2 // 2
        // 5.0/2 // 2.5
        // 5/2.0 // 2.5
        // 5.0/2.0 // 2.5

        Math.floor(3.4); // 3.0
        Math.floor(3.5); // 3.0
        Math.floor(3.6); // 3.0

        Math.ceil(3.4); // 4.0
        Math.ceil(3.5); // 4.0
        Math.ceil(3.6); // 4.0

        Math.round(3.4); // 3
        Math.round(3.5); // 4
        Math.round(3.6); // 4

        double round1 = Math.round(3.4564 * 10) / 10.0; // 3.5
        double round2 = Math.round(3.4564 * 100) / 100.0; // 3.46
    }

    public static void random() {
        Random rand = new Random();

        rand.nextDouble(); // 0 - 0.99999
        rand.nextInt(); // integer
        int i1 = rand.nextInt() * 3; // 0..3
        int i2 = rand.nextInt() * 5 + 20; // 5..25
        // int i3 = rand.nextInt() * diff + start; // start..start * diff
    }
}