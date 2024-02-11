public class _Rect {
    public String color;
    public int width;
    public int height;

    public _Rect() {
    }

    public _Rect(String color, int width, int height) {
        this.color = color;
        this.width = width;
        this.height = height;
    }

    public int Area() {
        return width * height;
    }

    public String ToString() {
        return "Rectangle, Color:" + color + " width:" + width + " height:" + height;
    }
}