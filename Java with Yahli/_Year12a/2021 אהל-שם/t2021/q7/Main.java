public class Main {
    public static void main(String[] args) {
        System.out.println("Hello World!");
        Vehicle[] vehicles = new Vehicle[] {
                new Car("Tesla", 100000, true, true),
                new Car("Toyota", 80000, false, false),
                new Bike("MountainBike", 5000, true, false),
                new Bike("CityBike", 3000, true, true),
                new Bike("DirtBike", 4500, true, false)
        };

        System.out.println("All Vehicles and their Final Prices:");
        for (Vehicle v : vehicles) {
            System.out.println(v.getModel() + " - Final Price: " + v.finalPrice());
        }

        System.out.println("\nOffroad and Electric Bikes:");
        Vehicle[] filtered = VehicleUtils.offroadAndElectric(vehicles);
        for (Vehicle v : filtered) {
            System.out.println(v.getModel());
        }

        System.out.println(vehicles.length);
    }
}
