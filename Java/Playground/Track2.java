import java.util.Arrays;

public class Track2 {
    public static void main(String[] args) {
        int[] numbers1 = { 3, 1, 2, 1, 4 };
        Q5 example1 = new Q5(numbers1);
        example1.fillModified1();
    }
}

class Q5 {
    public int[] arr1;
    public int[] arr2;

    public Q5(int[] a1) {
        this.arr1 = a1;
        this.arr2 = new int[a1.length];
    }

    public void fillModified1() {
        for (int i = 0; i < arr1.length; i++) {
            if (arr1[i] >= 0 && arr1[i] < arr2.length)
                arr2[arr1[i]] += (i + 1);
        }
    }
}
1