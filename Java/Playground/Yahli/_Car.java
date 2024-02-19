public class _Car {
    private String make;
    private String color;
    private _Wheel[] wheels;

    public _Car() {
    }

    public _Car(String make, String color, _Wheel[] wheels) {
        this.make = make;
        this.color = color;
        this.wheels = wheels;
    }

    public void drive() {
        // do something
    }

    public String ToString() {
        return "Car, make:" + make + " color:" + color + " num wheels:" + wheels.length;
    }
}