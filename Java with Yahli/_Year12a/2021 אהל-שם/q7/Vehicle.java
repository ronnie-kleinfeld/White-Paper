public abstract class Vehicle {
    protected String model;
    protected double bPrice;
    protected boolean electric;

    public Vehicle(String model, double bPrice, boolean electric) {
        this.model = model;
        this.bPrice = bPrice;
        this.electric = electric;
    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public double getBPrice() {
        return bPrice;
    }

    public void setBPrice(double bPrice) {
        this.bPrice = bPrice;
    }

    public boolean isElectric() {
        return electric;
    }

    public void setElectric(boolean electric) {
        this.electric = electric;
    }

    public abstract double finalPrice();
}
