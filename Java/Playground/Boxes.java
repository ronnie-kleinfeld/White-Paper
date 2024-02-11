public class Boxes {
    public _Box[] boxes;

    public Boxes() {
        boxes = new _Box[0];
    }

    public void Add(_Box box) {
        boxes[0] = box;
    }

    public void DeleteSmallBox() {
        int length = boxes.length;
        int index = 0;

        _Box myBox;
        int myBoxIndex;

        while (index < length) {
            _Box item = boxes[index];

            index++;
        }
    }
}