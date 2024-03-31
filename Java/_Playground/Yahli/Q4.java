public class Q4 {
    public static void main(String[] args) {
        Q4[] takis = {
                new Q4(3, "b"),
                new Q4(10, "b"),
                new Q4(4, "b"),
                new Q4(2, "g"),
                new Q4(10, "b") };
        System.out.println(q3(takis, new Q4(2, "b"))); // 4
        System.out.println(q3(takis, new Q4(2, "g"))); // 1
        System.out.println(q3(takis, new Q4(2, "r"))); // 1
        System.out.println(q3(takis, new Q4(5, "r"))); // 0
    }

    private int digit;
    private String color;

    public Q4(int digit, String color) {
        this.digit = digit;
        this.color = color;
    }

    public boolean greater(Q4 taki) {
        return this.digit > taki.digit;
    }

    public static int q3(Q4[] takis, Q4 topTaki) {
        int counter = 0;
        boolean same = false;
        for (int i = 0; i < takis.length; i++) {
            if (takis[i].digit == 10 && takis[i].color == topTaki.color) {
                for (int j = 0; j < takis.length; j++) {
                    if (takis[j].color == topTaki.color) {
                        counter++;
                    }
                }
                return counter;
            } else if (takis[i].digit == topTaki.digit || takis[i].color == topTaki.color) {
                same = true;
            }
        }

        if (same) {
            return 1;
        } else {
            return 0;
        }
    }
}