public class _Box {
    public String color;
    public int width;
    public int height;
    public int length;

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public _Box() {
    }

    public _Box(String color, int width, int height, int length) {
        this.color = color;
        this.width = width;
        this.height = height;
        this.length = length;
    }

    public int Area() {
        return width * height * length;
    }

    public String ToString() {
        return "Box, Color:" + color + " width:" + width + " height:" + height + " length:" + length;
    }
}