package Classes;

public class ClassesMain {
    public static void main(String[] args) {
        System.out.println("ClassesMain start");

        ClassA classA = new ClassA("Yahli");
        classA.ToString();

        ClassC.Static();

        System.out.println("ClassesMain end");
    }
}