import java.util.Scanner;

public class _Main {
    public static void main(String[] args) {
        System.out.println("1-Main.main: start"); // 1-Main.main: start

        static111("Blue");
        Airplane.static222();

        Airplane airplane = new Airplane("Ronnie");
        airplane.func(); // 5-Airplane.func: name=Ronnie

        Scanner scanner = new Scanner(System.in);
        String name = scanner.nextLine();
        Airplane airplane2 = new Airplane(name);
        airplane2.func(); // 6-Airplane.func: name=TheScanner

        System.out.println("7-Main.main: end"); // 6-Main.main: end
    }

    public static void static111(String color) {
        System.out.println("2-Main.static111: color=" + color); // 2-Main.static111: color=Blue
    }
}