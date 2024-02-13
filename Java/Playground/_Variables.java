import java.util.Arrays;

public class _Variables {
    public static void main(String[] args) {
        int i = 0;
        double d = 0;
        String str = "";
        char c = ' ';
        Boolean b = true; // false;

        System.out.println(i);
        System.out.println(d);
        System.out.println(str);
        System.out.println(c);
        System.out.println(b);

        int[] arri = new int[3];
        String[] arrstr = new String[3];
        char[] arrc = new char[3];
        Boolean[] arrb = new Boolean[3];
        _Box[] arrr = new _Box[3];

        System.out.println(Arrays.toString(arri));
        System.out.println(Arrays.toString(arrstr));
        System.out.println(Arrays.toString(arrc));
        System.out.println(Arrays.toString(arrb));
        System.out.println(Arrays.toString(arrr));

        char c1 = 'a';
        System.out.println(c1); // a
        System.out.println((int) c1); // 97
        System.out.println((char) 98);// b
    }
}