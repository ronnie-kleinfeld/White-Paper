public class ArrayFind {
    public static void main(String[] args) {
        System.out.println(FindByValue(new int[] { 0, 1, 2 }, 0));
        System.out.println(FindByValue(new int[] { 0, 1, 2 }, 2));
        System.out.println(FindByValue(new int[] { 0, 1, 2 }, 3));

        Box[] boxes = new Box[3];
        boxes[0] = new Box("Red", 1, 2, 3);
        boxes[1] = new Box("Red", 2, 3, 4);
        boxes[2] = new Box("Red", 3, 4, 5);

        System.out.println(FindByLength(boxes, 1));
        System.out.println(FindByLength(boxes, 2));
        System.out.println(FindByLength(boxes, 4));
    }

    public static int FindByValue(int[] arr, int value) {
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == value) {
                return arr[i];
            }
        }
        return -1;
    }

    public static int FindByLength(Box[] arr, int length) {
        for (int i = 0; i < arr.length; i++) {
            if (arr[i].length == length) {
                return i;
            }
        }
        return -1;
    }

    public static int FindByHighLength(Box[] arr) {

        for (int i = 0; i < arr.length; i++) {
            if (arr[i].length == length) {
                return i;
            }
        }
        return -1;
    }
}