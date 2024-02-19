public class Object {
    public static void initObject() {
        Box box1 = new Box();
        Box box2 = new Box("blue", 10, 15, 4);
    }

    public static void initArrayOfObjects() {
        Box[] boxes1 = new Box[2]; // [0, 0]
        Box[] boxes2 = new Box[2]; // [Box.., Box..]
    }
}
