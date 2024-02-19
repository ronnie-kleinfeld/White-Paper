public class IfSwitch {
    public static void main(String[] args) {
    }

    public static void doIf(String gender) {
        if (gender == "M")
            System.out.println("Male");
        if (gender == "F")
            System.out.println("Female");
        else
            System.out.println("Unknown");
    }

    public static void doSwitch(String gender) {
        switch (gender) {
            case "M":
                System.out.println("Male");
                break;
            case "F":
                System.out.println("Female");
                break;
            default:
                System.out.println("Unknown");
                break;
        }
    }
}