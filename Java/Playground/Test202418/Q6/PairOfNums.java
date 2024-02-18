package Test202418.Q6;

public class PairOfNums {
    private int num1;
    private int num2;

    public PairOfNums(int num1, int num2) {
        this.num1 = num1;
        this.num2 = num2;
    }

    public boolean endStart() {
        return num1 + num2 == 1000;
    }

    public String toString() {
        return num1 + ", " + num2 + "\n";
    }
}