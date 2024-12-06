public class LeftNum {
    public static void main(String[] args) {
        System.out.println(left(786));
        System.out.println(left(15));
        System.out.println(left(7));
    }

    public static int left(int num) {
        if (num < 10)
            return num;

        return left(num / 10);
    }
}
