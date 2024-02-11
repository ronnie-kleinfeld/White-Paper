public class _ArrayIter {
    public static void main(String[] args) {
        System.out.println(FindByValue(new int[] { 0, 1, 2 }, 0));
        System.out.println(FindByValue(new int[] { 0, 1, 2 }, 2));
        System.out.println(FindByValue(new int[] { 0, 1, 2 }, 3));

        _Rect[] rects = new _Rect[3];
        rects[0] = new _Rect("Red", 1, 2);
        rects[1] = new _Rect("Red", 2, 3);
        rects[2] = new _Rect("Red", 3, 4);

        System.out.println(FindByWidth(rects, 1));
        System.out.println(FindByWidth(rects, 2));
        System.out.println(FindByWidth(rects, 4));
    }

    // arr - char[7] {'a', 'b', 'c', 'd', 'e', 'f', 'g'};
    // pos - _________ 0 __ 1 __ 2 __ 3 __ 4 __ 5 __ 6
    // FindByWidth(arr, 'c') = 2
    // FindByWidth(arr, 'Z') = -1
    public static int FindByValue(int[] arr, int value) {
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == value) {
                return arr[i];
            }
        }
        return -1;
    }

    public static int FindByWidth(_Rect[] arr, int width) {
        for (int i = 0; i < arr.length; i++) {
            if (arr[i].width == width) {
                return i;
            }
        }
        return -1;
    }

    public static int FindByHighLength(_Rect[] arr) {

        for (int i = 0; i < arr.length; i++) {
            if (arr[i].width == width) {
                return i;
            }4
        }
        return -1;
    }
}