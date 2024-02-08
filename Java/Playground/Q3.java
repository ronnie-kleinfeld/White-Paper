public class Q3 {
    private int[] arr1;
    private int[] arr2;

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