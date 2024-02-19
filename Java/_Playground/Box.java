public class Box {
    // members
    public String color;
    public int width;
    public int height;
    public int length;

    // properties
    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    // ctor
    public Box() {
    }

    public Box(String color, int width, int height, int length) {
        this.color = color;
        this.width = width;
        this.height = height;
        this.length = length;
    }

    // methods
    public int Area() {
        return width * height * length;
    }

    public String ToString() {
        return "Box, Color:" + color + " width:" + width + " height:" + height + " length:" + length;
    }
}