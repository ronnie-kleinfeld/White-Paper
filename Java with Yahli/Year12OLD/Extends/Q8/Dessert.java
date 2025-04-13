package Extends.Q8;

public class Dessert extends Dish implements IResizable {
    private boolean iceCream;

    public Dessert(int price, boolean isVeg, NuFacts nf, boolean iceCream) {
        super(price, isVeg, nf);
        this.iceCream = iceCream;
    }

    public boolean isIceCream() {
        return iceCream;
    }

    public void setIceCream(boolean iceCream) {
        this.iceCream = iceCream;
    }

    @Override
    public void Increase() {
        int newPrice = getPrice() + 5;
        setPrice(newPrice);
    }
}