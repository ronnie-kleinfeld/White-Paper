public class Swimming {
    private int[] arr;
    private String name;

    public int deltas(boolean isLogner) {
        int goodDiff = 0;
        int badDiff = 0;

        for (int i = 1; i < arr.length - 1; i++) {
            if (arr[i] > arr[i - 1])
                badDiff += arr[i] - arr[i - 1];
            else
                goodDiff += arr[i] - arr[i - 1];
        }

        if (isLogner)
            return badDiff;
        else
            return goodDiff;
    }

    public boolean improving() {
        if (deltas(false) > deltas(true))
            return true;
        else
            return false;
    }
}