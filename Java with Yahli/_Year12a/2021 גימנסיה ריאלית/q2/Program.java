public class Program {
    private String pName;
    private int maxGrams;
    private boolean[] properKinds; // size 10

    public Program(String pName, int maxGrams, boolean[] properKinds) {
        this.pName = pName;
        this.maxGrams = maxGrams;
        this.properKinds = properKinds;
    }

    public String getPName() {
        return pName;
    }

    public void setPName(String pName) {
        this.pName = pName;
    }

    public int getMaxGrams() {
        return maxGrams;
    }

    public void setMaxGrams(int maxGrams) {
        this.maxGrams = maxGrams;
    }

    public boolean[] getProperKinds() {
        return properKinds;
    }

    public void setProperKinds(boolean[] properKinds) {
        this.properKinds = properKinds;
    }
}
