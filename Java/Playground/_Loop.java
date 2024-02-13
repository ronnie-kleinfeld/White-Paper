public class _Loop {
    public static void main(String[] args) {
        for (int i = 0; i < 10; i++) {
            // 0 1 2 3 4 5 6 7 8 9
        }

        for (int i = 0; i < 10; i += 2) {
            // 0 2 4 6 8
        }

        for (int i = 10 - 1; i >= 0; i--) {
            // 9 8 7 6 5 4 3 2 1 0
        }

        int count = 0;
        while (count < 10) {
            // 0 1 2 3 4 5 6 7 8 9
            count++;
        }

        count = 0;
        do {
            // 0 1 2 3 4 5 6 7 8 9
            count++;
        } while (count < 10);
    }
}