import java.util.Arrays;

public class _Variables {
    public static void main(String[] args) {
        int i = 0;
        System.out.println(i);

        double d = 0;
        System.out.println(d);

        String str = "";
        System.out.println(str);

        char c = ' ';
        System.out.println(c);

        Boolean b = true; // false;
        System.out.println(b);

        System.out.println();

        int[] arri = new int[3];
        System.out.println(Arrays.toString(arri));

        String[] arrstr = new String[3];
        System.out.println(Arrays.toString(arrstr));

        char[] arrc = new char[3];
        System.out.println(Arrays.toString(arrc));

        Boolean[] arrb = new Boolean[3];
        System.out.println(Arrays.toString(arrb));

        _Box[] arrr = new _Box[3];
        System.out.println(Arrays.toString(arrr));

        char c1 = 'a';
        System.out.println(c1); // a
        System.out.println((int) c1); // 97
        System.out.println((char) 98);// b
    }
}