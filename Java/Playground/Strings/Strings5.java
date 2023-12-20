package Strings;

public class Strings5 {

    public static void main(String[] args) {

        Necklace n1 = new Necklace();
        Necklace n2 = new Necklace("RRRYYYGGG");
        Necklace n3 = new Necklace("GRRRYYYGG", 3);
        Necklace n4 = new Necklace("GRYGGRYYRGGYRG", 4);
        Necklace n5 = new Necklace("GRYGGRYRGGYRG", 2);
        Necklace n6 = new Necklace("RGGGYYRYYRGR", 3);
        Necklace n7 = new Necklace(6, 2);
        Necklace n8 = new Necklace("GRRRYYYGG", 3);
        Necklace n9 = new Necklace("GRRRYYYGG", 2);
        Necklace n10 = new Necklace("GGYYYRRRG", 3);

        System.out.println("toString");
        System.out.println("n1 = " + n1.toString());
        System.out.println("n2 = " + n2);
        System.out.println("n3 = " + n3);
        System.out.println("n4 = " + n4);
        System.out.println("n5 = " + n5);
        System.out.println("n6 = " + n6);
        System.out.println("n7 = " + n7);

        System.out.println("\naddAtBegin");
        System.out.println("before n7 = " + n7 + "   addAtBegin(RRRR)");
        n7.addAtBegin("RRRR");
        System.out.println("after  n7 = " + n7);

        System.out.println("\naddAtEnd");
        System.out.println("before n7 = " + n7 + "   addAtEnd(YRYRG)");
        n7.addAtEnd("YRYRG");
        System.out.println("after  n7 = " + n7);

        System.out.println("\nequalColors");
        System.out.println("equalColors? n1 = " + n1 + " : " + n1.equalColors());
        System.out.println("equalColors? n2 = " + n2 + " : " + n2.equalColors());
        System.out.println("equalColors? n3 = " + n3 + " : " + n3.equalColors());
        System.out.println("equalColors? n4 = " + n4 + " : " + n4.equalColors());

        System.out.println("\nsymetric");
        System.out.println("symetric? n1 = " + n1 + " : " + n1.symetric());
        System.out.println("symetric? n4 = " + n4 + " : " + n4.symetric());
        System.out.println("symetric? n5 = " + n5 + " : " + n5.symetric());
        System.out.println("symetric? n7 = " + n7 + " : " + n7.symetric());

        System.out.println("\nidentical");
        System.out.println("identical?" + "\n\t" + n3 + "\n\t" + n4 + "\n\t" + n3.identical(n4));
        System.out.println("identical?" + "\n\t" + n3 + "\n\t" + n8 + "\n\t" + n3.identical(n8));
        System.out.println("identical?" + "\n\t" + n3 + "\n\t" + n9 + "\n\t" + n3.identical(n9));
        System.out.println("identical?" + "\n\t " + n3 + "\n\t" + n10 + "\n\t" + n3.identical(n10));

        System.out.println("\nisGrouped");
        System.out.println("isGrouped(" + n2 + ") ? " + isGrouped(n2));
        System.out.println("isGrouped(" + n3 + ") ? " + isGrouped(n3));

        System.out.println("\nsameOrder");
        n2.setTimes(3);
        System.out.println("sameOrder?" + "\n\t" + n2 + "\n\t" + n3 + "\n\t" + sameOrder(n2, n3));
        System.out.println("sameOrder?" + "\n\t" + n8 + "\n\t" + n3 + "\n\t" + sameOrder(n8, n3));

    }

    public static boolean isGrouped(Necklace n1) {

        return false;
    }

    public static boolean sameOrder(Necklace n1, Necklace n2) {

        return false;
    }

}
