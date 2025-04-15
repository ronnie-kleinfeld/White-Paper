public class Car extends Vehicle {
    private boolean automatic;

    public Car(String model, double bPrice, boolean electric, boolean automatic) {
        super(model, bPrice, electric);
        this.automatic = automatic;
    }

    public boolean isAutomatic() {
        return automatic;
    }

    public void setAutomatic(boolean automatic) {
        this.automatic = automatic;
    }

    @Override
    public double finalPrice() {
        double price = bPrice;
        if (electric)
            price += bPrice * 0.2;
        if (automatic)
            price += bPrice * 0.1;
        return price;
    }
}
