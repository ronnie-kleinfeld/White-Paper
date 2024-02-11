import java.utils.Math;

public class _Math {
    public static void main(String[] args) {
        int i1 = 5;

        double d1 = 5.0;

        System.out.println(5 / 2);
        System.out.println(5.0 / 2);
        System.out.println(5 / 2.0);
        System.out.println(5.0 / 2.0);

        System.out.println(Math.pow(3, 2));
        System.out.println(Math.sqrt(9));

        System.out.println(Math.floor(3.4));
        System.out.println(Math.floor(3.5));
        System.out.println(Math.floor(3.6));

        System.out.println(Math.ceil(3.4));
        System.out.println(Math.ceil(3.5));
        System.out.println(Math.ceil(3.6));

        System.out.println(Math.round(3.4));
        System.out.println(Math.round(3.5));
        System.out.println(Math.round(3.6));

        System.out.println(Math.round(3.4564 * 10) / 10.0);

        System.out.println(Math.random());
        System.out.println(Math.random() * 10);
        System.out.println(Math.random() * 3 + 52);
    }
}
