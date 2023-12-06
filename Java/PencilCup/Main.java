public class Main {

    public static void main(String[] args) {
        testInitObject();
        testToSame();
        testValue();
    }

    public static void testInitObject() {
        PencilCup p1 = new PencilCup();
        System.out.println(p1.getNumPencils());
        System.out.println(p1.getNumPens());
        System.out.println(p1.hasScissors());

        p1.setNumPencils(9);
        p1.setNumPens(p1.getNumPencils() / 2);
        p1.setScissors(true);

        System.out.println(p1.getNumPencils());
        System.out.println(p1.getNumPens());
        System.out.println(p1.hasScissors());
    }

    public static void testToSame() {
        PencilCup p1 = new PencilCup(4, 3, false);
        PencilCup p2 = new PencilCup(2, 5, true);
        System.out.println(p1 + " - " + p2);
        PencilCup.toSame(p1, p2);
        System.out.println(p1 + " - " + p2);

        System.out.println();

        PencilCup p3 = new PencilCup(1, 1, false);
        PencilCup p4 = new PencilCup(1, 1, true);
        System.out.println(p3 + " - " + p4);
        PencilCup.toSame(p3, p4);
        System.out.println(p3 + " - " + p4);
    }

    public static void testValue() {
        PencilCup p1 = new PencilCup(10, 15, true);
        System.out.println("Static     - 10:" + p1.value(10));
        System.out.println("NOT Static - 10:" + value(p1, 10));
    }

    public static int value(PencilCup p, int price) {
        int pencilsPrice = p.getNumPencils() * price;
        int pensPrice = p.getNumPens() * price * 3;
        int scissorsPrice = 0;
        if (p.hasScissors()) {
            scissorsPrice = price * 10;
        }
        return pencilsPrice + pensPrice + scissorsPrice;
    }
}