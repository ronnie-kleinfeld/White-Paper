public class Boxes {
    public Box[] boxes;

    public Boxes() {
        boxes = new Box[0];
    }

    public void Add(Box box) {
        boxes[0] = box;
    }

    public void DeleteSmallBox() {
        int length = boxes.length;
        int index = 0;

        Box myBox;
        int myBoxIndex;

        while (index < length) {
            Box item = boxes[index];

            index++;
        }
    }
}