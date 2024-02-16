public class Airplane {
    private String name;

    public String getName() {
        return this.name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Airplane(String name) {
        this.name = name;
    }

    public void func() {
        System.out.println(" -Airplane.func: name=" + this.name);

        // Airplane airplane = new Airplane("Yahli");
        // airplane.func();

        // func();
    }

    public static void static111() {
        System.out.println("3-Airplane.static222"); // 3-Airplane.static222
        Airplane airplane = new Airplane("Yahli");
        airplane.func(); // 4-Airplane.func: name=Yahli
    }
}