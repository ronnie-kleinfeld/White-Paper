package Classes;

public class ClassA {
    private String name;

    public ClassA(String name) {
        this.name = name;
    }

    public void ToString() {
        System.out.println("ClassA=" + name);
    }

    public static void Static() {
        System.out.println("ClassA");
    }
}