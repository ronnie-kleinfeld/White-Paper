
public class Program {
    private String name;
    private int maxGrams;
    private boolean[] properKinds;

    public Program(String name, int maxGrams, boolean[] properKinds) {
        this.name = name;
        this.maxGrams = maxGrams;
        this.properKinds = properKinds;
    }

    public boolean start(Cloth[] arr) {
        int totalGrams = 0;
        for (int i = 0; i < arr.length; i++) {
            totalGrams += arr[i].grams;

            if (!properKinds[arr[i].kind]) {
                return false;
            }
        }
        if (totalGrams > this.maxGrams) {
            return false;
        }

        return true;
    }
}