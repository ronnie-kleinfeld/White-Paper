package Test202418.Q6;

import java.util.Arrays;
import java.util.Random;

public class Q6 {
    public static void main(String[] args) {
        System.out.println(Arrays.toString(generate(15)));
    }

    public static PairOfNums[] generate(int n) {
        PairOfNums[] result = new PairOfNums[n];

        Random rand = new Random();
        // 1..n
        for (int i = 0; i < n; i++) {
            while (true) {
                int num1 = rand.nextInt(1000) + 1;
                int num2 = rand.nextInt(1000) + 1;

                PairOfNums pairOfNums = new PairOfNums(num1, num2);
                if (pairOfNums.endStart()) {
                    result[i] = pairOfNums;
                    break;
                }
            }
        }

        return result;
    }
}