public class Main {
    public static void main(String[] args) {
        System.out.println("Hello");

        int[] arr1 = { 3, 2, 1 };
        int[] arr2 = { 1, 9, 3, 4, 5, 8, 2 };

        System.out.println(allMemberIn(arr1, arr2));
    }

    public static boolean allMemberIn(int[] arr1, int[] arr2) {
        for (int i = 0; i < arr1.length; i++) {
            boolean check = false;
            for (int j = 0; j < arr2.length; j++) {
                if (arr1[i] == arr2[j]) {
                    check = true;
                }
            }
            if (check == false) {
                return false;
            }
        }

        return true;
    }
}