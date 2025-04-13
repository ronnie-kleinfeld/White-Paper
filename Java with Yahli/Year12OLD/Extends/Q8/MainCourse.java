package Extends.Q8;

public class MainCourse extends Dish implements IOrderable {
    private int kidPrice;

    public MainCourse(int price, boolean isVeg, NutFacts nf, int kidPrice) {
        super(price, isVeg, nf);
        this.kidPrice = kidPrice;
    }

    public int getKidPrice() {
        return kidPrice;
    }

    public void setKidPrice(int kidPrice) {
        this.kidPrice = kidPrice;
    }

    @Override
    public void OrderrNow() {
        System.out.println("Order placed for Main Course.");
    }
}