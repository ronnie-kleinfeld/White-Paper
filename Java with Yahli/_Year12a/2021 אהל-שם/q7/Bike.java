public class Bike extends Vehicle {
    private boolean street;

    public Bike(String model, double bPrice, boolean electric, boolean street) {
        super(model, bPrice, electric);
        this.street = street;
    }

    public boolean isStreet() {
        return street;
    }

    public void setStreet(boolean street) {
        this.street = street;
    }

    @Override
    public double finalPrice() {
        double price = bPrice;
        if (street)
            price += bPrice * 0.15;
        if (electric)
            price += bPrice * 0.1;
        return price;
    }
}
