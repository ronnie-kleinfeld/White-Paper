import java.util.Arrays;

public class Q3 {
    public static void main(String[] args) {
        int[] a = { 5, 1, 5, 11, 2, 5, 1 };

        Q3 q3 = new Q3(a);
        System.out.println(Arrays.toString(q3.arr1));
        System.out.println(Arrays.toString(q3.arr2));
        q3.fill();
        System.out.println(Arrays.toString(q3.arr1));
        System.out.println(Arrays.toString(q3.arr2));
    }

    public int[] arr1;
    public int[] arr2;

    public Q3(int[] a1) {
        this.arr1 = a1;
        this.arr2 = new int[a1.length];
    }

    public void fill() {
        for (int i = 0; i < arr1.length; i++) {
            if (arr1[i] >= 0 && arr1[i] < arr2.length)
                arr2[arr1[i]]++;
        }
    }
}