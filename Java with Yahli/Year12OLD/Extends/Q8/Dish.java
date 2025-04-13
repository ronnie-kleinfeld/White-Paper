package Extends.Q8;

public class Dish {
    protected int price;
    protected boolean isVeg;
    protected NutFacts nf;

    public Dish(int price, boolean isVeg, NutFacts nf) {
        this.price = price;
        this.isVeg = isVeg;
        this.nf = nf;
    }

    public int getPrice() {
        return price;
    }

    public void setPrice(int price) {
        this.price = price;
    }

    public boolean getIsVeg() {
        return isVeg;
    }

    public void setIsVeg(boolean isVeg) {
        this.isVeg = isVeg;
    }

    public NutFacts getNuFacts() {
        return nf;
    }

    public void setNuFacts(NutFacts nf) {
        this.nf = nf;
    }
}