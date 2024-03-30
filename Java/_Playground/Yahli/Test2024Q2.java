import java.util.Arrays;

public class Test2024Q2 {
    public static void main(String[] args) {

    }

    public static void runQuickWash(Cloth[] arr) {
        Program program = new Program(
                "Quick Wash",
                4000,
                new boolean[] { true, true, false, false, false, false, true, false, false, false });
        program.start(arr);
    }
}