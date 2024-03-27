import java.util.Arrays;

public class Weight {
    public static void main(String[] args) {
        Weight weight = new Weight(45123);
        System.out.println(weight.kilo);
        System.out.println(weight.gram);
    }

    private int kilo;
    private int gram;

    public Weight(int totalGram) {
        if (totalGram < 1000) {
            kilo = 0;
            gram = totalGram;
        } else {
            kilo = (int) (totalGram / 1000);
            gram = totalGram - kilo * 1000;
        }
    }

    public void add(Weight other) {
        this.kilo += other.kilo;
        this.gram += other.gram;
    }
}