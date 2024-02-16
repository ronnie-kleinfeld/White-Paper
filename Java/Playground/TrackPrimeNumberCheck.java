public class TrackPrimeNumberCheck {
    public static void main(String[] args) {
        System.out.println(isPrime(19)); // true
        System.out.println(isPrime(49)); // false

        for (int i = 0; i < 100; i++) {
            if (isPrime(i)) {
                System.out.print(i + ",");
            }
        }
    }

    public static boolean isPrime(int n) {
        if (n == 0 || n == 1) {
            return false;
        }
        if (n == 2) {
            return true;
        }
        for (int i = 2; i <= n / 2; i++) {
            if (n % i == 0) {
                return false;
            }
        }

        return true;
    }
}