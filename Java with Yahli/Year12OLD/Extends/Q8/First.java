package Extends.Q8;

public class First extends Dish implements IOrderable, IResizable {
    private int priceLarge;

    public First(int price, boolean isVeg, NuFacts nf, int priceLarge) {
        super(price, isVeg, nf);
        this.priceLarge = priceLarge;
    }

    public int getPriceLarge() {
        return priceLarge;
    }

    public void setPriceLarge(int priceLarge) {
        this.priceLarge = priceLarge;
    }

    @Override
    public void OrderrNow() {
        System.out.println("Order placed for First dish.");
    }

    @Override
    public void Increase() {
        System.out.println("Increasing size of First dish.");
        setPrice(getPrice() + 5); // Example increase
    }
}