public class Cloth {
    private String cName;
    private int grams;
    private int kind; // 0–9

    public Cloth(String cName, int grams, int kind) {
        this.cName = cName;
        this.grams = grams;
        this.kind = kind;
    }

    public String getCName() {
        return cName;
    }

    public void setCName(String cName) {
        this.cName = cName;
    }

    public int getGrams() {
        return grams;
    }

    public void setGrams(int grams) {
        this.grams = grams;
    }

    public int getKind() {
        return kind;
    }

    public void setKind(int kind) {
        this.kind = kind;
    }
}
