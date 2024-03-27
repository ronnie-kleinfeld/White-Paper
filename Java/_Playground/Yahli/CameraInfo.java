public class CameraInfo {
    private int city;
    private int maxSpeed;
    private CarInfo[] carsInfo;

    public boolean allGood(int maxSpeed) {
        return privateCar || speed > maxSpeed;
    }
}