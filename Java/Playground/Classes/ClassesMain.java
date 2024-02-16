package Classes;

public class ClassesMain {
    public static void main(String[] args) {
        System.out.println("ClassesMain start");

        ClassA classA = new ClassA("Yahli");
        classA.ToString();

        Static();
        ClassA.Static();
        ClassC.Static();

        ClassB classB = new ClassB(17);
        classB.ToString();

        System.out.println("ClassesMain end");
    }

    public static void Static() {
        System.out.println("ClassesMain");
    }
}