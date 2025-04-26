public class Main {
    public static void main(String[] args) {
        // Create 3 clothes
        Cloth c1 = new Cloth("Shirt", 500, 2);
        Cloth c2 = new Cloth("Towel", 1000, 3);
        Cloth c3 = new Cloth("Jeans", 800, 2);

        // Put clothes in array
        Cloth[] clothes = { c1, c2, c3 };

        // Create a properKinds array: only kind 2 and 3 are allowed
        boolean[] properKinds = new boolean[10];
        properKinds[2] = true;
        properKinds[3] = true;

        // Create a Program that accepts up to 3000 grams
        Program p = new Program("Quick Wash", 3000, properKinds);

        // Start the washing machine
        boolean result = LaundryMachine.start(clothes, p);

        // Output
        if (result) {
            System.out.println("Laundry program can start ✅");
        } else {
            System.out.println("Laundry program rejected ❌");
        }
    }
}
