import java.util.Arrays;

public class Numberele {
    public static void main(String[] args) {
        Numberele numberele = new Numberele(new int[] { 7, 5, 3, 1, 2, 4 });

        char[] cs = numberele.specialCompare1(new int[] { 8, 5, 7, 4, 2, 0 });
        System.out.println(Arrays.toString(cs));

        cs = numberele.specialCompare1(new int[] { 8, 5, 7, 4, 2, 0 });
        System.out.println(Arrays.toString(cs));

        cs = numberele.specialCompare2(new int[] { 7, 4, 9, 1, 6, 0 });
        System.out.println(Arrays.toString(cs));

        cs = numberele.specialCompare2(new int[] { 7, 4, 9, 1, 6, 0 });
        System.out.println(Arrays.toString(cs));
        // GYXGXX
    }

    private int[] nums;

    public Numberele(int[] nums) {
        this.nums = nums;
    }

    public char[] specialCompare1(int[] arr) {
        char[] result = new char[arr.length];

        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == nums[i]) {
                result[i] = 'G';
            } else {
                result[i] = 'X';
                for (int j = 0; j < arr.length; j++) {
                    if (arr[i] == nums[j]) {
                        result[i] = 'Y';
                    }
                }
            }
        }

        return result;
    }

    public char[] specialCompare2(int[] arr) {
        char[] result = new char[arr.length];

        for (int i = 0; i < arr.length; i++) {
            result[i] = 'X';
            for (int j = 0; j < arr.length; j++) {
                if (arr[i] == nums[i])
                    result[i] = 'G';
                else if (arr[i] == nums[j])
                    result[i] = 'Y';
            }
        }

        return result;
    }
}