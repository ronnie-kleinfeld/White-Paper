public class Taki {
    public static void main(String[] args) {
        Taki[] takis = {
                new Taki(3, "b"),
                new Taki(10, "b"),
                new Taki(4, "b"),
                new Taki(2, "g"),
                new Taki(10, "b") };
        System.out.println(q3(takis, new Taki(2, "b"))); // 4
        System.out.println(q3(takis, new Taki(2, "g"))); // 1
        System.out.println(q3(takis, new Taki(2, "r"))); // 1
        System.out.println(q3(takis, new Taki(5, "r"))); // 0
    }

    private int digit;
    private String color;

    public Taki(int digit, String color) {
        this.digit = digit;
        this.color = color;
    }

    public boolean greater(Taki taki) {
        return this.digit > taki.digit;
    }

    public static int q3(Taki[] takis, Taki topTaki) {
        for (int i = 0; i < takis.length; i++) {
            if (takis[i].digit == 10 && takis[i].color == topTaki.color) {
                int count = 0;
                for (int j = 0; j < takis.length; j++) {
                    if (takis[j].color == topTaki.color) {
                        count++;
                    }
                }
                return count;
            }
        }

        for (int i = 0; i < takis.length; i++) {
            if (takis[i].digit == topTaki.digit || takis[i].color == topTaki.color) {
                return 1;
            }
        }

        return 0;
    }
}