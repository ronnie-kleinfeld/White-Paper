import java.utils.Math;

public class _Wheel {
    private int radius;

    public _Wheel() {
    }

    public _Wheel(int radius) {
        this.radius = radius;
    }

    public double area() {
        return Math.PI * radius * radius;
    }

    public String ToString() {
        return "Wheel, radius:" + radius;
    }
}