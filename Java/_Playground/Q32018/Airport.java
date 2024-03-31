package Q32018;

public class Airport {
    public Flight[] flights;

    public boolean isFly() {
        for (int i = 0; i < flights.length; i++) {
            if (flights[i].name.equals("Sky")) {
                return true;
            }
        }
        return false;
    }
}