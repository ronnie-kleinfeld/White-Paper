import java.util.Scanner;

public class _Main {
    public static void main(String[] args) {
        static111("Blue");

        Airplane airplane = new Airplane("F35");
        airplane.func();

        Airplane.func();
        static111();
    }

    public static void static111(String color) {
        System.out.println("2-Main.static111: color=" + color); // 2-Main.static111: color=Blue
    }
}