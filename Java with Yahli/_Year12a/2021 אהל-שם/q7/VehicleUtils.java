import java.util.ArrayList;

public class VehicleUtils {
    public static Vehicle[] offroadAndElectric(Vehicle[] vehicles) {
        ArrayList<Vehicle> result = new ArrayList<>();

        for (Vehicle v : vehicles) {
            if (v.isElectric() && v instanceof Bike) {
                Bike b = (Bike) v;
                if (!b.isStreet()) {
                    result.add(b);
                }
            }
        }

        return result.toArray(new Vehicle[0]);
    }
}
