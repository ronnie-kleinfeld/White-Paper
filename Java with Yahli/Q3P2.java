public class Q3P2 {
    public static void main(String[] args) {
        int start = 2;

        for (Integer i = start; i < start + 100000000; i++) {
            long value = i;
            int counter = 1;

            System.out.print(value);
            while (value != 1) {
                if (value % 2 == 0) {
                    value = value / 2;
                } else {
                    value = value * 3 + 1;
                }
                // if (value < 0) {
                // System.out.print("Negative - " + value);
                // break;
                // }

                counter++;
                // if (counter > 10000) {
                // System.out.println("Something wrong");
                // }
                // System.out.print(", " + value);
            }
            System.out.println(" - " + counter);
        }
    }
}